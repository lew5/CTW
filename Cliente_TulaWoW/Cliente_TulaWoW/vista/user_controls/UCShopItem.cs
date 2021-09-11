using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCShopItem : UserControl
    {
        public UCShopItem()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        public Image Fondo
        {
            get => this.BackgroundImage;
            set
            {
                this.BackgroundImage = value;
            }
        }
        public String ItemName
        {
            get => glbl_ItemName.Text;
            set
            {
                glbl_ItemName.Text = value;
            }
        }
        public String ItemDesc
        {
            get => glbl_ItemDesc.Text;
            set
            {
                glbl_ItemDesc.Text = value;
            }
        }
        public String ItemPrice
        {
            get => glbl_ItemPrice.Text;
            set
            {
                glbl_ItemPrice.Text = value;
            }
        }
    }
}
