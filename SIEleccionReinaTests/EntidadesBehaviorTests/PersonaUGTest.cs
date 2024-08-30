using SIEleccionReina.Entidades;
using SIEleccionReina.Modelos;

namespace SIEleccionReinaTests.EntidadesBehaviorTests
{
    public class PersonaUGTest
    {
        public PersonaUGTest() { }

        [Theory]
        [InlineData( "Jose Alberto", "Jose", "Alberto" )]
        [InlineData( "Juan  Pablo", "Juan", "Pablo" )]
        [InlineData( "Clark     Joseph", "Clark", "Joseph" )]
        [InlineData( "Lois       Andrea", "Lois", "Andrea" )]
        [InlineData( "Ana          Camila", "Ana", "Camila" )]
        public void SepararNombresTest( string nombresPersona, string primerNombrePersona, string segundoNombrePersona ) 
        {
            // Dado que PersonaUG es una clase abstracta, para probar su comportamiento, se lo hará desde sus clases hijas ClsEstudiante y ClsCandidata

            // *****
            // ***** Arrange - Preparación
            // *****

            ClsEstudiante estudianteConstructor;
            ClsEstudiante estudiantePropiedad;
            ClsCandidata candidataConstructor;
            ClsCandidata candidataPropiedad;

            // *****
            // ***** Act - Acción
            // *****

            // Prueba pasando parametros al constructor
            // Solamente se asignara el parametro 'nombres' dado que es el objetivo de esta prueba,
            // todos los demas parametros se llenaran con cadenas vacias "", 0 o valores de ejemplo

            estudianteConstructor = new ClsEstudiante( idEstudiante: 0,
                                                       idCarrera: 0,
                                                       cedula: "",
                                                       semestre: 1,
                                                       contrasenia: "",
                                                       id_rol_usuario: 0,
                                                       nombres: nombresPersona,
                                                       apellidos: "" );

            candidataConstructor = new ClsCandidata( idCandidata: 0,
                                                     idCarrera: 0,
                                                     cedula: "",
                                                     nombres: nombresPersona,
                                                     apellidos: "",
                                                     semestre: 1,
                                                     foto: "",
                                                     fecha_nacimiento: DateTime.Now,
                                                     edad: 100,
                                                     aspiraciones: "",
                                                     intereses: "",
                                                     habilidades: "" );

            // Prueba usando la Propiedad
            estudiantePropiedad = new ClsEstudiante() { Nombres = nombresPersona };
            candidataPropiedad = new ClsCandidata() { Nombres = nombresPersona };

            // *****
            // ***** Assert - Afirmación
            // *****

            Assert.Equal( expected: primerNombrePersona, actual: estudianteConstructor.PrimerNombre );
            Assert.Equal( expected: primerNombrePersona, actual: estudiantePropiedad.PrimerNombre );
            Assert.Equal( expected: primerNombrePersona, actual: candidataConstructor.PrimerNombre );
            Assert.Equal( expected: primerNombrePersona, actual: candidataPropiedad.PrimerNombre );

            Assert.Equal( expected: segundoNombrePersona, actual: estudianteConstructor.SegundoNombre );
            Assert.Equal( expected: segundoNombrePersona, actual: estudiantePropiedad.SegundoNombre );
            Assert.Equal( expected: segundoNombrePersona, actual: candidataConstructor.SegundoNombre );
            Assert.Equal( expected: segundoNombrePersona, actual: candidataPropiedad.SegundoNombre );
        }
    }
}
