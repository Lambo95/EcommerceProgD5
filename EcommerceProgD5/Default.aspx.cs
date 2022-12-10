using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceProgD5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Prodotto> p = new List<Prodotto>();
                p = Prodotto.GetList();
                
                Repeater1.DataSource = p;
                Repeater1.DataBind();

            }


        }

        protected void AggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int magliaSel=Convert.ToInt32( b.CommandArgument) ;

            foreach (Prodotto pl in Prodotto.GetList())
            {
                if(pl.Id == magliaSel)
                {
                    Prodotto maglia = new Prodotto() { Img = pl.Img, Titolo = pl.Titolo, Descrizione = pl.Descrizione, Prezzo = pl.Prezzo};
                    Prodotto.Carrello.Add(maglia);
                }
            }

        }
    }

    public class Prodotto
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public static List<Prodotto> Carrello = new List<Prodotto>();
        public static List<Prodotto> GetList()
        {
            List<Prodotto> prodotti = new List<Prodotto>();

            Prodotto p1 = new Prodotto { Id = 1, Img = "~/Media/index1.jpg", Titolo = "Maglietta 1", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 5.00 };
            Prodotto p2 = new Prodotto { Id = 2, Img = "~/Media/index2.jpg", Titolo = "Maglietta 2", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 7.50 };
            Prodotto p3 = new Prodotto { Id = 3, Img = "~/Media/index3.jpg", Titolo = "Maglietta 3", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 6.80 };
            Prodotto p4 = new Prodotto { Id = 4, Img = "~/Media/index4.jpg", Titolo = "Maglietta 4", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 12.00 };
            Prodotto p5 = new Prodotto { Id = 5, Img = "~/Media/index5.jpg", Titolo = "Set Magliette 1", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 18.00 };
            Prodotto p6 = new Prodotto { Id = 6, Img = "~/Media/index6.jpg", Titolo = "Set Magliette 2", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non tellus ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Cras mattis consectetur turpis, et vestibulum dui volutpat vitae. Quisque et tellus blandit, auctor justo non, tristique eros.", Prezzo = 26.00 };

            prodotti.Add(p1);
            prodotti.Add(p2);
            prodotti.Add(p3);
            prodotti.Add(p4);
            prodotti.Add(p5);
            prodotti.Add(p6);
            return prodotti;
        }


    }
}