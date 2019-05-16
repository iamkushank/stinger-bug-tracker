using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccessClassLibrary
{
    public class UserClass
    {
        MySqlConnection cmd = new MySqlConnection(DB.connectionstring);
        
        public bool ManageUser(int id, String firstname, String lastname, String username, String password, String role, int Mode)
        {
            try
            {
                bool result = false;
                string txtsql = "";
                if (Mode == 1)
                    txtsql = "Insert into tbl_members (firstname, lastname, username, password, role) values (@fn, @ln, @usn, @pass, @role)";
                if (Mode == 2)
                    txtsql = "Update tbl_members set firstname=@fn, lastname=@ln, username=@usn,password=@pass,role=@role where id=@id";
                if(Mode == 3)
                    txtsql = "Delete from tbl_members where id=@id";

                MySqlCommand sc = new MySqlCommand(txtsql, cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@id",id);
                sc.Parameters.AddWithValue("@fn", firstname);
                sc.Parameters.AddWithValue("@ln", lastname);
                sc.Parameters.AddWithValue("@usn",username);
                sc.Parameters.AddWithValue("@pass",password);
                sc.Parameters.AddWithValue("@role",role);
                cmd.Open();
                    int x = sc.ExecuteNonQuery();
                cmd.Close();
                    if (x>0)
                        result = true;
                    else
                        result = false;
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Close();
            }


        }

        public bool Login(string username, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand sc = new MySqlCommand("Select * from tbl_members where username=@usn and password=@pass", cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@usn", username);
                sc.Parameters.AddWithValue("@pass", password);

                cmd.Open();
                MySqlDataReader dr = sc.ExecuteReader();
                dt.Load(dr);
                cmd.Close();

                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
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

        public bool RoleBaseLogin(string username, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand sc = new MySqlCommand("Select * from tbl_members where username=@usn and password=@pass", cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@usn", username);
                sc.Parameters.AddWithValue("@pass", password);

                cmd.Open();
                MySqlDataReader dr = sc.ExecuteReader();
                dt.Load(dr);
                cmd.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
    }
}
