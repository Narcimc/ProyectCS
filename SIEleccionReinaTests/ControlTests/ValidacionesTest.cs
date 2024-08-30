using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReinaTests.ControlTests
{
    public class ValidacionesTest
    {
        string[] nullEmptyWhitespaces = new string[] { null, String.Empty, "", " ", "    " };
        TextBox TxtControl;
        ComboBox ComboCarrera;

        public ValidacionesTest() 
        {
            TxtControl = new TextBox();
            ComboCarrera = new ComboBox();
            ComboCarrera.Items.Add( "Selecciona una opción" );
            ComboCarrera.Items.Add( "Ciencia de Datos e Inteligencia Artificial" );
            ComboCarrera.Items.Add( "Ingeniería Civil" );
            ComboCarrera.Items.Add( "Ingeniería en Software" );
            ComboCarrera.Items.Add( "Tecnología de la Información" );
        }

        [Theory]
        [InlineData( "0912356489" )]
        [InlineData( "0000054689" )]
        [InlineData( "0000000000" )]
        [InlineData( "9999999999" )]
        [InlineData( "1234567890" )]
        public void UserCedulaShouldBeValid( string cedula ) 
        {
            TxtControl.Text = cedula;
            Assert.True( Validaciones.IsUserCedulaValid( TxtControl ) );
        }

        [Theory]
        [InlineData( "0954568  " )]
        [InlineData( "  09875642" )]
        [InlineData( "1234   890" )]
        [InlineData( "12 45  890" )]
        [InlineData( "   " )]
        [InlineData( "          " )]
        [InlineData( "12545  890" )]
        public void UserCedulaShouldNOTBeValid( string cedula )
        {
            TxtControl.Text = cedula;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsUserCedulaValid( TxtControl ) );
        }

        [Theory]
        [InlineData( "contra123" )]
        [InlineData( "passw123;" )]
        [InlineData( "contra#12@" )]
        [InlineData( "Contra123Semi-Segura." )]
        [InlineData( "1234" )]
        public void PasswordShouldBeValid( string password ) 
        {
            TxtControl.Text = password;
            Assert.True( Validaciones.IsPasswordValid( TxtControl ) );
        }

        [Fact]
        public void PasswordShouldNOTBeValid() 
        {
            foreach ( string item in nullEmptyWhitespaces ) 
            {
                TxtControl.Text = item;
                Assert.Throws<InvalidValueException>( () => Validaciones.IsPasswordValid( TxtControl ) );
            }
        }

        [Theory]
        [InlineData( "contra123", "contra123" )]
        [InlineData( "passw123;", "passw123;" )]
        [InlineData( "contra#12@", "contra#12@" )]
        [InlineData( "Contra123Semi-Segura.", "Contra123Semi-Segura." )]
        [InlineData( "1234", "1234" )]
        public void PasswordConfirmationShouldBeValid( string password, string passwordConfirmation )
        {
            TxtControl.Text = passwordConfirmation;
            Assert.True( Validaciones.IsPasswordConfirmationValid( password, TxtControl ) );
        }

        [Theory]
        [InlineData( "contra123", "contra123456" )]
        [InlineData( "passw123;", "passw123;*" )]
        [InlineData( "contra#12@", "contra12@" )]
        [InlineData( "Contra123Semi-Segura.", "Contra123Semi_Segura." )]
        [InlineData( "1234", "1234 " )]
        public void PasswordConfirmationShouldNOTBeValid( string password, string passwordConfirmation )
        {
            TxtControl.Text = passwordConfirmation;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsPasswordConfirmationValid( password, TxtControl ) );
        }

        [Theory]
        [InlineData( "Ana Carolina" )]
        [InlineData( "Maria Eugenia" )]
        [InlineData( "Clark")]
        [InlineData( " Fernández Cordero" )]
        [InlineData( "López Jiménez " )]
        public void NameLastNameShouldBeValid( string nameLastName )
        {
            TxtControl.Text = nameLastName;
            Assert.True( Validaciones.IsNameLastNameValid( TxtControl ) );
        }

        [Theory]
        [InlineData( "Ana +Carolina" )]
        [InlineData( "Maria Eugeni@;" )]
        [InlineData( "Clark." )]
        [InlineData( " Fernández Cordero5" )]
        [InlineData( "López Jiménez21@ " )]
        public void NameLastNameShoulNOTdBeValid( string nameLastName )
        {
            TxtControl.Text = nameLastName;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsNameLastNameValid( TxtControl ) );
        }

        [Theory]
        [InlineData( "Tocar guitarra y el piano, ver ánime;." )]
        [InlineData( "Graduarme y convertirme en profesional, ser una persona de excelencia, tener un buen trabajo que aporte a la sociedad." )]
        [InlineData( "Destreza para la cocina, la repostería y los piqueos tradicionales." )]
        [InlineData( " Ser Ingeniera en Software y aportar con mis habilidades a la industria y a la sociedad. " )]
        [InlineData( "Patinaje artístico, cocina mediterránea y danza contemporánea  " )]
        public void InteresesAspiracionesHabilidadesShouldBeValid( string interAspHab )
        {
            TxtControl.Text = interAspHab;
            Assert.True( Validaciones.IsInteresesAspiracionesHabilidadesValid( TxtControl ) );
        }

        [Theory]
        [InlineData( "Tocar guitarra y el pian@, ver ánime%=." )]
        [InlineData( "Graduarme y convertirme en profesional ☺, ser una persona de excelencia, tener un buen trabajo que aporte a la sociedad ♥." )]
        [InlineData( "Destreza para la cocina*, la repostería y los piqueos tradicionales8." )]
        [InlineData( " Ser Ingeniera en Software y aportar con mis habilidades a la industria y a la sociedad 5iempre. " )]
        [InlineData( "Patinaje artístico, cocina mediterránea y danza contemporánea /123 " )]
        public void InteresesAspiracionesHabilidadesShoulNOTdBeValid( string interAspHab )
        {
            TxtControl.Text = interAspHab;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsInteresesAspiracionesHabilidadesValid( TxtControl ) );
        }

        [Fact]
        public void CarreraShouldBeValid()
        {
            int[] indexes = { 1, 2, 3, 4 };
            string[] carreras = { "Ingeniería Industrial", "Comunicación Social", "Psicología", "Turismo", "Ingeniería Química" };

            foreach ( int index in indexes ) 
            {
                ComboCarrera.SelectedIndex = index;
                Assert.True( Validaciones.IsCarreraValid( ComboCarrera ) );
            }

            foreach ( string carrera in carreras )
            {
                TxtControl.Text = carrera;
                Assert.True( Validaciones.IsCarreraValid( TxtControl ) );
            }
        }

        [Fact]
        public void CarreraShoulNOTdBeValid()
        {
            string[] carreras = { "   ", "....", "12345678", "Carre123", " Seleccione la carrera de sus sueños ", "Selecciona la carrera ché" };

            ComboCarrera.SelectedIndex = 0;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsCarreraValid( ComboCarrera ) );

            foreach ( string carrera in carreras )
            {
                TxtControl.Text = carrera;
                Assert.Throws<InvalidValueException>( () => Validaciones.IsCarreraValid( TxtControl ) );
            }
        }

        [Theory]
        [InlineData( "Caminando en el Jardin" )]
        [InlineData( "Mi Perro" )]
        [InlineData( "Mi persona" )]
        [InlineData( "Mi Familia" )]
        [InlineData( "Sesion Fotográfica" )]
        public void FotoTituloDataShouldBeValid( string tituloFoto )
        {
            TxtControl.Name = "TituloFoto";
            TxtControl.Text = tituloFoto;

            Assert.True( Validaciones.IsFotoDataValid( TxtControl ) );
            TxtControl.Name = "";
        }

        [Theory]
        [InlineData( "Me encuentro caminando; por los bellos jardines de Guayaquil" )]
        [InlineData( "Aquí está mi querido amigo canino siempre me acompaña" )]
        [InlineData( "Soy yo con un look casual." )]
        [InlineData( "Mi familia acompañándome siempre." )]
        [InlineData( "Mi tercera sesión, de fotos siempre muy chévere." )]
        public void FotoDescripcionDataShouldBeValid( string descripcionFoto )
        {
            TxtControl.Text = descripcionFoto;

            Assert.True( Validaciones.IsFotoDataValid( TxtControl ) );
        }

        [Fact]
        public void FotoDataWithNullEmptyWShouldNOTBeValid()
        {
            foreach ( string item in nullEmptyWhitespaces )
            {
                TxtControl.Text = item;
                Assert.Throws<InvalidValueException>( () => Validaciones.IsFotoDataValid( TxtControl ) );
            }
        }

        [Theory]
        [InlineData( "Caminand@ en el Jardin." )]
        [InlineData( "Mi Perro7" )]
        [InlineData( "Mi-person@" )]
        [InlineData( "M1 Familia" )]
        [InlineData( "Sesion Fotográfica;" )]
        public void FotoTituloDataShouldNOTBeValid( string tituloFoto )
        {
            TxtControl.Name = "TituloFoto";
            TxtControl.Text = tituloFoto;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsFotoDataValid( TxtControl ) );
            TxtControl.Name = "";
        }

        [Theory]
        [InlineData( "Me encuentro caminando por los bellos #jardines de Guayaquil=" )]
        [InlineData( "Aquí está mi qu3rido amigo canino, siempre me acompaña." )]
        [InlineData( "Soy yo con un look casual<>" )]
        [InlineData( "Mi familia, &acompañándome $iempre" )]
        [InlineData( "Mi t3rcera sesión de fotos, siempre muy chévere." )]
        public void FotoDescripcionDataShouldNOTBeValid( string descripcionFoto )
        {
            TxtControl.Text = descripcionFoto;
            Assert.Throws<InvalidValueException>( () => Validaciones.IsFotoDataValid( TxtControl ) );
        }
    }
}
