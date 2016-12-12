using System;
using System.Data;
using System.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        response.write('ddd');
        lbl1.Text = DateTime.Now.ToString();
    }
}