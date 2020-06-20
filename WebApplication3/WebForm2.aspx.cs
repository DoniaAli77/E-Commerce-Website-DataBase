using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void registerationvendor(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("vendorRegister", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string firstname = text_box_first_name.Text;
            string lastname = textbox_last_name.Text;
            string email = textbox_email.Text;
            string username = textbox_username.Text;
            string password = textbox_password.Text;
            string bank = textbox_Bank_account_num.Text;
            string company = textbox_Companyname.Text;
            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@first_name", firstname));
            cmd.Parameters.Add(new SqlParameter("@last_name", lastname));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@company_name", company));
            cmd.Parameters.Add(new SqlParameter("@bank_acc_no", bank));
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("you have been registred");
            }
            catch (Exception ex)
            {
                Response.Write("please enter valid usrename or valid bank account");
            }

            conn.Close();


        }

        protected void registerationcustomer(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn2 = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("customerRegister", conn2);

            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string firstname = text_box_first_name.Text;
            string lastname = textbox_last_name.Text;
            string email = textbox_email.Text;
            string username = textbox_username.Text;
            string password = textbox_password.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@first_name", firstname));
            cmd.Parameters.Add(new SqlParameter("@last_name", lastname));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            conn2.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("you have been registrted");

            }
            catch (Exception ex)
            {
                Response.Write("please enter valid usernsame ");
            }
            conn2.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx", true);
        }
    }
}