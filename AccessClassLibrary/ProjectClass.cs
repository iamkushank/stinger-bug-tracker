using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccessClassLibrary
{
    public class ProjectClass
    {
        MySqlConnection cmd = new MySqlConnection(DB.connectionstring);

        public bool ManageProjects(int projectid, String projectname, String startdate, String enddate, String description, int Mode)
        {
            try
            {
                bool result = false;
                string txtsql = "";
                if (Mode == 1)
                    txtsql = "Insert into tbl_projects (projectname, startdate, enddate, description) values (@pname, @sdate, @edate, @description)";
                if (Mode == 2)
                    txtsql = "Update tbl_projects set projectname=@pname, startdate=@sdate, enddate=@edate, description=@description where projectid=@pid";
                if (Mode == 3)
                    txtsql = "Delete from tbl_projects where projectid=@pid";

                MySqlCommand sc = new MySqlCommand(txtsql, cmd);
                sc.CommandType = CommandType.Text;
                sc.Parameters.AddWithValue("@pid", projectid);
                sc.Parameters.AddWithValue("@pname", projectname);
                sc.Parameters.AddWithValue("@sdate", startdate);
                sc.Parameters.AddWithValue("@edate", enddate);
                sc.Parameters.AddWithValue("@description", description);
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

        public DataTable getallproject()
        {
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand("Select * from tbl_projects", cmd);
            cmd.Open();
            MySqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            cmd.Close();
            return dt;
        }

        public DataTable getallprojectbyid(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand com = new MySqlCommand("Select * from tbl_projects where projectid =@pid", cmd);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@pid", id);
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

























