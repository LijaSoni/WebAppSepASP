using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebAppSepASP
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-NQSQA0KQ\SQLEXPRESS;database=ASPExample;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string-    '"+ +"'
            //int-    "+ +"
            string strins = "insert into tab1 values('"+TextBox1.Text+"',"+TextBox2.Text+",'"+TextBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(strins,con);//cmd=insert query
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i==1)
            {
                Label1.Text = "Succesfully inserted ";
            }
        }
    }
} 