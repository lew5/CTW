using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCSeccionJuego : UserControl
    {
        private string videoLink = "https://www.youtube.com/watch?v=Yqpk0MQ_QfY";
        private string azerothcoreLink = "https://www.azerothcore.org";
        private string tulaWoWLink = "http://www.tula-wow.com/";

        private string gamePath = "C:/wow/UltimoWoW esMX/Wow.exe";
        private string realmlistPath = "C:\\wow\\UltimoWoW esMX\\Data\\esMX\\realmlist.WTF";

        private string realmlist = "SET REALMLIST LOGON.CHROMIECRAFT.COM";

        public string VideoLink { get => videoLink; set => videoLink = value; }
        public string AzerothcoreLink { get => azerothcoreLink; set => azerothcoreLink = value; }
        public string GamePath { get => gamePath; set => gamePath = value; }
        public string Realmlist { get => realmlist; set => realmlist = value; }
        public string RealmlistPath { get => realmlistPath; set => realmlistPath = value; }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void centrarImg(Control a, Control b)
        {
            b.Location = new Point((a.Width / 2) - (b.Width / 2), (a.Height / 2) - (b.Height / 2));
        }

        public UCSeccionJuego()
        {
            InitializeComponent();
            centrarImg(glpnl_video, gtpbox_playvideo);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void gtpbox_azerothcoreBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(azerothcoreLink);
            //lineChanger("new content for this line", realmlistPath, 1);
        }

        private void gtpbox_ajustesBtn_MouseEnter(object sender, EventArgs e)
        {
            gtpbox_ajustesBtn.Image = Properties.Resources.settings_black_hover;
        }
        private void gtpbox_ajustesBtn_MouseLeave(object sender, EventArgs e)
        {
            gtpbox_ajustesBtn.Image = Properties.Resources.settings_black_24dp;
        }

        private void gtpbox_playvideo_MouseEnter(object sender, EventArgs e)
        {
            gtpbox_playvideo.Image = Properties.Resources.play_hover;
            centrarImg(glpnl_video, gtpbox_playvideo);
        }

        private void gtpbox_playvideo_MouseLeave(object sender, EventArgs e)
        {
            gtpbox_playvideo.Image = Properties.Resources.play;
            centrarImg(glpnl_video,gtpbox_playvideo);
        }

        private void ggbtn_jugar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gamePath);
        }

        private void gtpbox_playvideo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(videoLink);
        }

        private void gunaTransfarantPictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(tulaWoWLink);
        }
    }
}
