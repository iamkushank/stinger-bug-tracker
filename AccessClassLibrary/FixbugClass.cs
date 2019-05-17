using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccessClassLibrary
{
    public class FixbugClass
    {
        MySqlConnection cmd = new MySqlConnection(DB.connectionstring);

        public bool ManageFixbug(int solutionid, string date, int projectid, int bugid, string Class, string code, string method, string classlibrary, int linenumber, string solvedby, byte[] error, int Mode)
        {
            try
            {

                bool result = false;
                string txtsql = "";
                if (Mode == 1)
                    txtsql = "Insert into tbl_solutions (solutionid, date, projectid, bugid, class, code, method, classlibrary, linenumber, solvedby, error) values (@sid, @date, @pid, @bid, @class, @code, @method, @clibrary, @linenumber, @solvedby, @error)";
                if (Mode == 2)
                    txtsql = "Update tbl_solutions set solutionid=@sid, date=@date, projectid=@pid, bugid=@bid, class=@class, code=@code, method=@method, classlibryary=@clibrary, linenumber=@lnumber, solvedby=@solvedby, error=@error,  where solutionid=@sid";
                if (Mode == 3)
                    txtsql = "Delete from tbl_solutions where solutionid=@sid";

                MySqlCommand sc = new MySqlCommand(txtsql, cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@sid", solutionid);
                sc.Parameters.AddWithValue("@date", date);
                sc.Parameters.AddWithValue("@pid", projectid);
                sc.Parameters.AddWithValue("@bid", bugid);
                sc.Parameters.AddWithValue("@class", Class);
                sc.Parameters.AddWithValue("@code", code);
                sc.Parameters.AddWithValue("@method", method);
                sc.Parameters.AddWithValue("@clibrary", classlibrary);
                sc.Parameters.AddWithValue("@lnumber", linenumber);
                sc.Parameters.AddWithValue("@solvedby", solvedby);
                sc.Parameters.AddWithValue("@error", error);
                cmd.Open();
                int x = sc.ExecuteNonQuery();
                cmd.Close();
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Close();
            }
        }

        public DataTable getallsolution()
        {
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand("Select * from tbl_solutions", cmd);
            cmd.Open();
            MySqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            cmd.Close();
            return dt;
        }

        public DataTable getallsolutionbyid(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand com = new MySqlCommand("Select * from tbl_solutions where solutionid =@sid", cmd);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@sid", id);
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
