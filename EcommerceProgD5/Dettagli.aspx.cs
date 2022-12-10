using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceProgD5
{
    public partial class Dettagli : System.Web.UI.Page
    {
        List<Prodotto> pList = new List<Prodotto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["idProdotto"];

            foreach (Prodotto p in Prodotto.GetList())
            {
                if (p.Id.ToString() == id)
                {
                    imgProdotto.ImageUrl = p.Img;
                    lblNomeProdotto.Text = p.Titolo;
                    lblPrezzoProdotto.Text = p.Prezzo.ToString("c2");
                    pList.Add(p);
                }
            }
        }

        protected void AggiungiAlCarrello_Click(object sender, EventArgs e)
        {
          foreach(Prodotto p in pList)
            {
               Prodotto.Carrello.Add(p);
            }
        }
    }
}