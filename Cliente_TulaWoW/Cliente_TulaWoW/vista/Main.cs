using Cliente_TulaWoW.vista.user_controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cliente_TulaWoW
{
    public partial class Main : Form
    {

        //private string url = "http://www.tula-wow.com/changelog";

        private void mostrarSeccionUC<UC>(Control p) where UC : UserControl, new()
        {
            UserControl uc;
            uc = p.Controls.OfType<UC>().FirstOrDefault();
            if (uc == null)
            {
                uc = new UC();
                p.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                foreach (Control c in p.Controls)
                    if (uc.Name != c.Name)
                    {
                        c.Dispose();
                    }
            }
            else
            {
                uc.BringToFront();
            }
        }

        public Main()
        {
            InitializeComponent();
            mostrarSeccionUC<UCSeccionJuego>(cpnl_seccionContenedor);
            //this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        private void ucNavBar1_ButtonJuegoClick(object sender, EventArgs e)
        {
            mostrarSeccionUC<UCSeccionJuego>(cpnl_seccionContenedor);
        }

        private void ucNavBar1_ButtonCambiosClick(object sender, EventArgs e)
        {
            mostrarSeccionUC<UCSeccionCambios>(cpnl_seccionContenedor);
        }

        private void ucNavBar1_ButtonTiendaClick(object sender, EventArgs e)
        {
            mostrarSeccionUC<UCSeccionTienda>(cpnl_seccionContenedor);
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    UCChangelogCard uCChangelogCard = new UCChangelogCard();
        //    uCChangelogCard.FechaCambio = "11/11/2020";
        //    uCChangelogCard.nuevoDetalleCambio("awa", "awAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciae");
        //    panel1.Controls.Add(uCChangelogCard);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var web = new HtmlWeb();
        //    var doc = web.Load(url);


        //    //HtmlNode div_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[1]//tr[1]/td/div");
        //    //HtmlNode a_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[1]//tr[2]/td/a");
        //    //HtmlNode td_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[1]//tr[3]/td");

        //    int nice_tableCount = doc.DocumentNode.SelectNodes("//*[@class='nice_table']").ToList().Count;

        //    for (int i = 1; i <= nice_tableCount; i++)
        //    {
        //        HtmlNode div_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[" + i + "]//tr[1]/td/div");
        //        HtmlNode a_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[" + i + "]//tr[2]/td/a");
        //        HtmlNode td_changelog_info = doc.DocumentNode.SelectSingleNode("//*[@id='changelog']/table[" + i + "]//tr[3]/td");

        //        string sdiv_changelog_info = div_changelog_info.InnerText;
        //        string sa_changelog_info = a_changelog_info.InnerText;
        //        string std_changelog_info = td_changelog_info.InnerText;

        //        lbl_div_changelog_info.Text = sdiv_changelog_info;
        //        lbl_a_changelog_info.Text = sa_changelog_info;
        //        lbl_td_changelog_info.Text = std_changelog_info;
        //    }

        //}
    }
}
