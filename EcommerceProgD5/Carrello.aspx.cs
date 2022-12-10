using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceProgD5
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                Repeater1.DataSource = Prodotto.Carrello;
                Repeater1.DataBind();

        }

        protected void SvuotaCestino_Click(object sender, EventArgs e)
        {
            Prodotto.Carrello.Clear();
            
        }
    }
}