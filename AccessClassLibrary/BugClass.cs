using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccessClassLibrary
{
    public class BugClass
    {
        MySqlConnection cmd = new MySqlConnection(DB.connectionstring);

        public bool ManageBugs(String date, string projectid, string bug, string Class, string code, string method, string classlibrary, int linenumber, string identifiedby, byte[] error, int Mode)
        {
            bool result = false;
            try
            {
                string txtsql = "";
                if (Mode == 1)
                    txtsql = "Insert into tbl_bugs (date, projectname, bug, class, code, method, classlibrary, linenumber, identifiedby, error) values (@date, @pid, @bug, @class, @code, @method, @clibrary, @linenumber, @identifiedby, @error)";
                if (Mode == 2)
                    txtsql = "Update tbl_bugs set date=@date, projectid=@pid, bug=@bug, class=@class, code=@code, method=@method, classlibryary=@clibrary, linenumber=@lnumber, identifiedby=@identifiedby, error=@error,  where bugid=@bid";
                if (Mode == 3)
                    txtsql = "Delete from tbl_bugs where bugid=@bid";

                MySqlCommand sc = new MySqlCommand(txtsql, cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@date", date);
                sc.Parameters.AddWithValue("@pid", projectid);
                sc.Parameters.AddWithValue("@bug", bug);
                sc.Parameters.AddWithValue("@class", Class);
                sc.Parameters.AddWithValue("@code", code);
                sc.Parameters.AddWithValue("@method", method);
                sc.Parameters.AddWithValue("@clibrary", classlibrary);
                sc.Parameters.AddWithValue("@lnumber", linenumber);
                sc.Parameters.AddWithValue("@identifiedby", identifiedby);
                sc.Parameters.AddWithValue("@error", error);
                cmd.Open();
                int x = sc.ExecuteNonQuery();
                cmd.Close();
                if (x > 0)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Close();
            }
            return result;
        }

        public DataTable getallbug()
        {
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand("Select * from tbl_bugs", cmd);
            cmd.Open();
            MySqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            cmd.Close();
            return dt;
        }

        public DataTable getallbugbyid(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand com = new MySqlCommand("Select * from tbl_bugs where bugid =@bid", cmd);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@bid", id);
                cmd.Open();
                MySqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                cmd.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
