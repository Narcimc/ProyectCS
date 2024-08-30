using SIEleccionReina.Control;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormSplash : Form
    {
        public FormSplash() 
        { 
            InitializeComponent();
            Cursor = Cursors.AppStarting;
            this.LblVersion.Text = $"Versión {AssemblyVersion}";
            this.LblVersion.Font = new Font( CommonUtils.GetCustomFont( CustomFontFamilies.LeelawadeeUI ), CommonUtils.FONT_SIZE_BIG_SUB_TITLE, FontStyle.Bold );
        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
