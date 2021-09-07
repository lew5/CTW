using System.Drawing;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCShopItem_rc : UserControl
    {
        private bool dk = false;
        private Point imgLocation;
        private Point nombreLocation;
        private Point btnLocation;
        private Point habilidadesLocation;

        public UCShopItem_rc()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            imgLocation = gtpbox_img.Location;
            nombreLocation = glbl_nombre.Location;
            habilidadesLocation = gtpbox_habilidades.Location;
            btnLocation = ggbtn_comprar.Location;
        }

        public Image Img
        {
            get => gtpbox_img.Image;
            set
            {
                this.gtpbox_img.Image = value;
            }
        }
        public Image Habilidades
        {
            get => gtpbox_habilidades.Image;
            set
            {
                this.gtpbox_habilidades.Image = value;
            }
        }
        public string Nombre
        {
            get => glbl_nombre.Text;
            set
            {
                this.glbl_nombre.Text = value;
            }
        }
        public Color Fondo
        {
            get => gepnl_fondo.BaseColor;
            set
            {
                this.gepnl_fondo.BaseColor = value;
            }
        }

        public Color BtnBaseColor1
        {
            get => ggbtn_comprar.BaseColor1;
            set
            {
                ggbtn_comprar.BaseColor1 = value;
            }
        }

        public Color BtnBaseColor2
        {
            get => ggbtn_comprar.BaseColor2;
            set
            {
                ggbtn_comprar.BaseColor2 = value;
            }
        }

        public Color BtnHoverColor1
        {
            get => ggbtn_comprar.OnHoverBaseColor1;
            set
            {
                ggbtn_comprar.OnHoverBaseColor1 = value;
            }
        }

        public Color BtnHoverColor2
        {
            get => ggbtn_comprar.OnHoverBaseColor2;
            set
            {
                ggbtn_comprar.OnHoverBaseColor2 = value;
            }
        }

        //public bool Dk
        //{
        //    get => dk; 
        //    set
        //    {
        //        dk = value;
        //        isClass(value);
        //    }
        //}

        public Size ImgSize
        {
            get => gtpbox_img.Size;
            set
            {
                gtpbox_img.Size = value;
            }
        }

        public Point NombreLocation
        {
            get => glbl_nombre.Location;
            set
            {
                glbl_nombre.Location = value;
            }
        }

        //private void isClass(bool pdk)
        //{
        //    if (pdk)
        //    {
        //        gtpbox_img.Location = new Point(0, 0);
        //        NombreLocation = new Point(gepnl_fondo.Width - (glbl_nombre.Width + 13), nombreLocation.Y);
        //        gtpbox_habilidades.Location = new Point(gepnl_fondo.Width - (gtpbox_habilidades.Width + 20), habilidadesLocation.Y);
        //        ggbtn_comprar.Location = new Point(gepnl_fondo.Width - (ggbtn_comprar.Width + 20), btnLocation.Y);
        //        ggbtn_comprar.BaseColor1 = Color.FromArgb(21, 124, 227);
        //        ggbtn_comprar.BaseColor2 = Color.FromArgb(1, 87, 173);
        //        ggbtn_comprar.OnHoverBaseColor1 = Color.FromArgb(31, 134, 237);
        //        ggbtn_comprar.OnHoverBaseColor2 = Color.FromArgb(11, 97, 183);
        //    }
        //    else
        //    {
        //        gtpbox_img.Location = imgLocation;
        //        NombreLocation = nombreLocation;
        //        gtpbox_habilidades.Location = habilidadesLocation;
        //        ggbtn_comprar.Location = btnLocation;
        //        ggbtn_comprar.BaseColor1 = Color.FromArgb(227, 75, 21);
        //        ggbtn_comprar.BaseColor2 = Color.FromArgb(174, 47, 1);
        //        ggbtn_comprar.OnHoverBaseColor1 = Color.FromArgb(237, 85, 31);
        //        ggbtn_comprar.OnHoverBaseColor2 = Color.FromArgb(184, 57, 11);
        //    }
        //}

        private void ggbtn_comprar_Click(object sender, System.EventArgs e)
        {
        }

        private void UCShopItem_rc_Load(object sender, System.EventArgs e)
        {
        }
    }
}
