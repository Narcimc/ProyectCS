using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using SIEleccionReina.Properties;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace SIEleccionReinaTests.ControlTests
{
    public class CommonUtilsTests
    {
        ComboBox TestingCombo;
        TextBox TxtContrasenia;

        public CommonUtilsTests()
        {
            TestingCombo = new ComboBox();
            TxtContrasenia = new TextBox();
        }

        [Fact]
        public void ComboShouldHaveTipoUsuarioItems() 
        { 
            if( TestingCombo.Items.Count > 0 )
                TestingCombo.Items.Clear();

            CommonUtils.LlenarComboTipoUsuario( TestingCombo );
            Array tipoUsuarioItems = Enum.GetValues( typeof( TipoUsuario ) );
            List<ComboBoxItem> testingComboItems = ( List<ComboBoxItem> ) TestingCombo.DataSource;

            Assert.Equal( tipoUsuarioItems.Length, testingComboItems.Count );

            for ( int index = 0; index < testingComboItems.Count; index++ )
            {
                Assert.Equal( ( int ) tipoUsuarioItems.GetValue( index ) + 1, testingComboItems[ index ].Value );
                Assert.Equal( tipoUsuarioItems.GetValue( index ).ToString(), testingComboItems[ index ].Display );
            }
        }

        [Fact]
        public void ComboShouldHaveSpecifiedItems() 
        {
            if ( TestingCombo.Items.Count > 0 )
                TestingCombo.Items.Clear();

            Dictionary<int, string> testingDict = new() 
            {
                { 1, "Element1" },
                { 2, "Item2" },
                { 3, "Este es el Elemento 3" },
                { 5, "Cuarto Item" },
                { 7, "Alguna de las Carreras" }
            };

            KeyValuePair<int, string>[] testingDictArray = testingDict.ToArray();
            CommonUtils.LlenarCombo( TestingCombo, testingDict );
            List<ComboBoxItem> testingComboItems = ( List<ComboBoxItem> ) TestingCombo.DataSource;

            Assert.Equal( testingDict.Count, testingComboItems.Count );

            for ( int index = 0; index < testingDictArray.Length; index++ ) 
            {
                Assert.Equal( testingDictArray[ index ].Key, testingComboItems[ index ].Value );
                Assert.Equal( testingDictArray[ index ].Value, testingComboItems[ index ].Display );
            }
        }

        [Fact]
        public void PasswordTxtShouldBeHidden() 
        {
            TxtContrasenia.PasswordChar = '\0';
            PictureBox HiddenIcon = new PictureBox();
            HiddenIcon.Image = Resources.visibility_off_24px_001928_FILL1_wght400_GRAD0_opsz24;

            CommonUtils.MostrarOcultarContrasenia( TxtContrasenia, HiddenIcon );

            byte[] expectedResourceImageByteArray = ImageToByte( Resources.visibility_24px_001928_FILL1_wght400_GRAD0_opsz24 );
            byte[] actualImageByteArray = ImageToByte( HiddenIcon.Image );

            Assert.Equal( '*', TxtContrasenia.PasswordChar );
            Assert.Equal( expectedResourceImageByteArray, actualImageByteArray );
        }           

        [Fact]
        public void PasswordTxtShouldBeShown()
        {
            TxtContrasenia.PasswordChar = '*';
            PictureBox ShowingIcon = new PictureBox();
            ShowingIcon.Image = Resources.visibility_24px_001928_FILL1_wght400_GRAD0_opsz24;

            CommonUtils.MostrarOcultarContrasenia( TxtContrasenia, ShowingIcon );

            byte[] expectedResourceImageByteArray = ImageToByte( Resources.visibility_off_24px_001928_FILL1_wght400_GRAD0_opsz24 );
            byte[] actualImageByteArray = ImageToByte( ShowingIcon.Image );

            Assert.Equal( '\0', TxtContrasenia.PasswordChar );
            Assert.Equal( expectedResourceImageByteArray, actualImageByteArray );
        }

        private byte[] ImageToByte( Image image ) 
        {
            using ( MemoryStream ms = new MemoryStream() )
            {   // Convert Image to byte[]
                image.Save( ms, ImageFormat.Jpeg );
                return ms.ToArray();
            }
        }
    }
}