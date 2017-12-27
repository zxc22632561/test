using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String res = "";
        int n = Convert.ToInt32(TextBox1.Text);

        for(int i=1; i <= n; i++)
        {
            for(int j=1; j <= i; j++)
            {
                res += i + "*" + j + "=" + (i * j)+"\t";
            }
            res += "\r\n"; //跳行
        }
        txtOutput.Text = res;
    }
}