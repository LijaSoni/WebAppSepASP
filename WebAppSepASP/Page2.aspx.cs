using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSepASP
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            c = a + b;
            Label3.Text = Convert.ToString(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text)- Convert.ToInt32(TextBox2.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            c = a * b;
            Label3.Text = c.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label3.Text = (Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}