using System.Drawing;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCNavBar : UserControl
    {
        public UCNavBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;    
        }
    }
}
