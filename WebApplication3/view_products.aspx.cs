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
    public partial class view_products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("ShowProductsbyPrice", conn);
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
                string product_desc = rdr.GetString(rdr.GetOrdinal("product_description"));

                Decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                string color = rdr.GetString(rdr.GetOrdinal("color"));


                //Create a new label and add it to the HTML form
                Label lbl_serial_no = new Label();
                lbl_serial_no.Text = "serial no  : " + serial_no + " || ";
                form1.Controls.Add(lbl_serial_no);


                Label lbl_product_name = new Label();
                lbl_product_name.Text ="product name : "+ productName+" || ";
                form1.Controls.Add(lbl_product_name);


                Label lbl_product_desc = new Label();
                lbl_product_desc.Text = "product_desc : "+ product_desc +" || ";// "  <br /> <br />";
                form1.Controls.Add(lbl_product_desc);

                Label lbl_price = new Label();
                lbl_price.Text ="price : "+ price + " || ";
                form1.Controls.Add(lbl_price);

                Label lbl_color = new Label();
                lbl_color.Text = "color : "+ color + "<br /> <br /> ";
                form1.Controls.Add(lbl_color);





            }
            //this is how you retrive data from session variable.
            //  string field1 = (string)(Session["field1"]);
            //    Response.Write(field1);

        }
    }
}