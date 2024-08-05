using SIEleccionReina.Control;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
            this.Text = String.Format( "Acerca de {0}", AssemblyTitle );
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format( "Version {0}", AssemblyVersion );
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyTitleAttribute ), false );
                if ( attributes.Length > 0 )
                {
                    AssemblyTitleAttribute titleAttribute = ( AssemblyTitleAttribute ) attributes[ 0 ];
                    if ( titleAttribute.Title != "" )
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension( Assembly.GetExecutingAssembly().CodeBase );
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyDescriptionAttribute ), false );
                if ( attributes.Length == 0 )
                {
                    return "";
                }
                return ( ( AssemblyDescriptionAttribute ) attributes[ 0 ] ).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyProductAttribute ), false );
                if ( attributes.Length == 0 )
                {
                    return "";
                }
                return ( ( AssemblyProductAttribute ) attributes[ 0 ] ).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyCopyrightAttribute ), false );
                if ( attributes.Length == 0 )
                {
                    return "";
                }
                return ( ( AssemblyCopyrightAttribute ) attributes[ 0 ] ).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyCompanyAttribute ), false );
                if ( attributes.Length == 0 )
                {
                    return "";
                }
                return ( ( AssemblyCompanyAttribute ) attributes[ 0 ] ).Company;
            }
        }
        #endregion

        private void FormAcercaDe_Load( object sender, EventArgs e ) => EstablecerTipografias();

        private void EstablecerTipografias()
        {
            labelProductName.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            labelVersion.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            labelCompanyName.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            labelCopyright.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            textBoxDescription.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            BtnClose.Font = CommonUtils.PredefinedCustomFonts.SubActionButtonFont;
        }

        private void BtnClose_Click( object sender, EventArgs e ) => Close();
    }
}
