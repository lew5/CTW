using System.Drawing;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCShopItem_rc : UserControl
    {
        private Image img = null;
        private Image habilidades = null;

        private string nombre = "";

        private Color fondo = Color.FromArgb(14, 14, 14);

        public UCShopItem_rc()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
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
    }
}
