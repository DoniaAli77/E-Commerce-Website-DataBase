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
    public partial class Vendor_view_product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("vendorviewProducts", conn);
            string vendorusername = (string)(Session["username"]);
            cmd.Parameters.Add(new SqlParameter("@vendorname", vendorusername));


            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                //Get the value of the attribute name in the Company table
                int serial_no = rdr.GetInt32(rdr.GetOrdinal("serial_no"));
                ///  Response.Write(serial_no);
                string productName = rdr.GetString(rdr.GetOrdinal("product_name"));
                //Get the value of the attribute field in the Company table
                string color = rdr.GetString(rdr.GetOrdinal("color"));
                string product_desc = rdr.GetString(rdr.GetOrdinal("product_description"));
                Decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));




                Decimal fprice = rdr.GetDecimal(rdr.GetOrdinal("final_price"));
                string category = rdr.GetString(rdr.GetOrdinal("category"));

                Boolean available = rdr.GetBoolean(rdr.GetOrdinal("available"));//
                string vendor_username = rdr.GetString(rdr.GetOrdinal("vendor_username"));

                 // string customer_username = rdr.GetString(rdr.GetOrdinal("customer_username"));
                //  int order_id = rdr.GetInt32(rdr.GetOrdinal("customer_order_id"));







                //Create a new label and add it to the HTML form
                Label lbl_serial_no = new Label();
                lbl_serial_no.Text = "serial no  : " + serial_no + " || ";
                form1.Controls.Add(lbl_serial_no);


                Label lbl_product_name = new Label();
                lbl_product_name.Text = "product name : " + productName + " || ";
                form1.Controls.Add(lbl_product_name);


                Label lbl_product_desc = new Label();
                lbl_product_desc.Text = "product_desc : " + product_desc + " || ";// "  <br /> <br />";
                form1.Controls.Add(lbl_product_desc);

                Label lbl_price = new Label();
                lbl_price.Text = "price : " + price + " || ";
                form1.Controls.Add(lbl_price);

                Label lbl_color = new Label();
                lbl_color.Text = "color : " + color + "<br /> <br /> ";
                form1.Controls.Add(lbl_color);


                Label lbl_fprice = new Label();
                lbl_fprice.Text = "final pricce  : " + fprice + " || ";
                form1.Controls.Add(lbl_fprice);

                Label lbl_category = new Label();
                lbl_category.Text = " category  : " + category + " || ";
                form1.Controls.Add(lbl_category);


                try
                {
                    int rate = rdr.GetInt32(rdr.GetOrdinal("rate"));
                    Label lbl_rate = new Label();
                    lbl_rate.Text = "  rate  : " + rate + " || ";
                    form1.Controls.Add(lbl_rate);



                }
                catch (Exception ex)
                {
                    Label lbl_rate = new Label();
                    lbl_rate.Text = "  rate  : " + "NULL" + " || ";
                    form1.Controls.Add(lbl_rate);
                };


                Label lbl_available = new Label();
                lbl_available.Text = " Available  : " + available + " || ";
                form1.Controls.Add(lbl_available);

                Label lbl_vendor_username = new Label();
                lbl_vendor_username.Text = " vendor_username  : " + vendor_username + " ## " + "<br /> <br /> ";

                form1.Controls.Add(lbl_vendor_username);

                Label a = new Label();
                a.Text = "<br /> <br /> ";
                form1.Controls.Add(a);



                try
                {
                    string customer_username = rdr.GetString(rdr.GetOrdinal("customer_username"));
                    Label lbl_customer_username = new Label();
                    lbl_serial_no.Text = "  customer_username  : " + customer_username + " || ";
                    form1.Controls.Add(lbl_customer_username);


                }
                catch (Exception ex)
                {
                    Label lbl_customer_username = new Label();
                    lbl_serial_no.Text = "  customer_username  : " + "NULL" + " || ";
                    form1.Controls.Add(lbl_customer_username);
                };


                try
                {
                    int order_id = rdr.GetInt32(rdr.GetOrdinal("customer_order_id"));
                    Label lbl_order_id = new Label();
                    lbl_serial_no.Text = " order_id  : " + order_id + " || ";
                    form1.Controls.Add(lbl_order_id);


                }
                catch (Exception ex)
                {
                    Label lbl_order_id = new Label();
                    lbl_serial_no.Text = " order_id  : " + "NULL" + " || ";
                    form1.Controls.Add(lbl_order_id);
                };



                /*               int order_id = rdr.GetInt32(rdr.GetOrdinal("customer_order_id"));
                                Label lbl_order_id = new Label();
                                lbl_serial_no.Text = " order_id  : " + order_id + " || ";
                                form1.Controls.Add(lbl_order_id);
                */


            }
            //this is how you retrive data from session variable.
            //  string field1 = (string)(Session["field1"]);
            //    Response.Write(field1);

        }
    }

}

