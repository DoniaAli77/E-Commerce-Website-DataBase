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
    public partial class vendor : System.Web.UI.Page
    {
        /*  protected void Page_Load(object sender, EventArgs e)
         {

              string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
              SqlConnection conn = new SqlConnection(connStr);

              SqlCommand cmd = new SqlCommand("getallCompanies", conn);
              cmd.CommandType = CommandType.StoredProcedure;

              conn.Open();

              //IF the output is a table, then we can read the records one at a time
              SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
              while (rdr.Read())
              {
                  //Get the value of the attribute name in the Company table
                  string companyName = rdr.GetString(rdr.GetOrdinal("name"));
                  //Get the value of the attribute field in the Company table
                  string companyField = rdr.GetString(rdr.GetOrdinal("field"));

                  //Create a new label and add it to the HTML form
                  Label lbl_CompanyName = new Label();
                  lbl_CompanyName.Text = companyName + "  speciliazes in ";
                  form1.Controls.Add(lbl_CompanyName);


                  Label lbl_CompanyField = new Label();
                  lbl_CompanyField.Text = companyField + "  <br /> <br />";
                  form1.Controls.Add(lbl_CompanyField);
              }
          }*/

        protected void postProduct(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("postProduct", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            string username = (string)(Session["username"]);
            Response.Write(username);

            //To read the input from the user

            string product_name = text_box_productname.Text;
            string category = text_box_category.Text;
            string product_description = text_box_productdescription.Text;
            string price = text_box_price.Text;
            string color = text_box_color.Text;
            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@vendorUsername", username));
            cmd.Parameters.Add(new SqlParameter("@product_name", product_name));
            cmd.Parameters.Add(new SqlParameter("@category", category));
            cmd.Parameters.Add(new SqlParameter("@product_description", product_description));
            cmd.Parameters.Add(new SqlParameter("@price", price));
            cmd.Parameters.Add(new SqlParameter("@color", color));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write(" you have posted the product ");
            }
            catch (Exception ex)
            {
                Response.Write("something is not right, please enter valid info ");
            };

            conn.Close();


        }

        protected void vendorviewProducts(object sender, EventArgs e)
        {

            Response.Redirect("Vendor_view_product.aspx", true);



        }

        protected void createoffersproc(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("addOffer", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            string username = (string)(Session["username"]);
            Response.Write(username);

            //To read the input from the user


            string offeramount = txt_box_offerramount.Text;
            string expiry_date = txt_box_expirydate.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@offeramount", offeramount));
            cmd.Parameters.Add(new SqlParameter("@expiry_date", expiry_date));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("you have created an offer ");
            }
            catch (Exception ex)
            {
                Response.Write("faild , please add valid info ");
            };

            conn.Close();

        }

        protected void checkandremoveexpireoffer(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("checkandremoveExpiredoffer", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            string username = (string)(Session["username"]);
            Response.Write(username);

            //To read the input from the user


            string offerid = text_offer_id.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@offerid", offerid));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("success , check your offers");
            }
            catch (Exception ex)
            {
                Response.Write("faild, please enter valid offer id");
            };

            conn.Close();
        }

        protected void applyoffer(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("applyOffer", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            string username = (string)(Session["username"]);
            Response.Write(username);

            //To read the input from the user

            string offerid = txt_offerid.Text;
            string serial = txt_box_pserial.Text;


            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@vendorname", username));
            cmd.Parameters.Add(new SqlParameter("@offerid", offerid));
            cmd.Parameters.Add(new SqlParameter("@serial", serial));


            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("you have applied offer");//mess
            }
            catch (Exception ex)
            {
                Response.Write("please ass valid info");
            };

            conn.Close();





        }

        protected void vendoreditProducts(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            SqlCommand cmd = new SqlCommand("EditProduct", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            string username = (string)(Session["username"]);
            Response.Write(username);

            //To read the input from the user

            string serialnumber = text_box_serialno.Text;
            string product_name = txtbox_product_name.Text;
            string category = txtbox_category.Text;
            string product_description = txtbox_product_description.Text;
            string price = txtbox_price.Text;
            string color = txtbox_color.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@vendorname", username));
            cmd.Parameters.Add(new SqlParameter("@serialnumber", serialnumber));
            cmd.Parameters.Add(new SqlParameter("@product_name", product_name));
            cmd.Parameters.Add(new SqlParameter("@category", category));
            cmd.Parameters.Add(new SqlParameter("@product_description", product_description));
            cmd.Parameters.Add(new SqlParameter("@price", price));
            cmd.Parameters.Add(new SqlParameter("@color", color));



            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("   you have edited the product , PLEASE CHECK ");//mess
            }
            catch (Exception ex)
            {
                Response.Write(" please you have to enter all these fields");
            };

            conn.Close();



        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addMobile", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            string username = (string)(Session["username"]);
            string mob = TextBox1.Text;
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@mobile_number", mob));
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("phone added correctly");
            }
            catch (Exception ex)
            {
                Response.Write("phone have not been added correctly");
            };
            conn.Close();
        }
    }
}