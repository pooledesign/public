public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl1.Text = DateTime.Now.ToString();
    }
}