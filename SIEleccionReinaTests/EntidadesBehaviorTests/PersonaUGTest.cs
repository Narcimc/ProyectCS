using SIEleccionReina.Entidades;
using SIEleccionReina.Modelos;

namespace SIEleccionReinaTests.EntidadesBehaviorTests
{
    public class PersonaUGTest
    {
        public PersonaUGTest() { }

        [Fact]
        public void SepararNombresTest() 
        {
            // Dado que PersonaUG es una clase abstracta, para probar su comportamiento, se lo hará desde sus clases hijas ClsEstudiante y ClsCandidata

            // *****
            // ***** Arrange - Preparación
            // *****

            string[] nombres = new string[] { "Jose Alberto", "Juan Pablo", "Clark Joseph", "Lois Andrea", "Ana Camila"  };
            string[] primerNombre = new string[] { "Jose", "Juan", "Clark", "Lois", "Ana" };
            string[] segundoNombre = new string[] { "Alberto", "Pablo", "Joseph", "Andrea", "Camila" };
            List<PersonaUG> listaPersonasConstructor = new List<PersonaUG>();
            List<PersonaUG> listaPersonasPropiedad = new List<PersonaUG>();

            // *****
            // ***** Act - Acción
            // *****

            // Prueba pasando parametros al constructor
            // Solamente se asignara el parametro 'nombres' dado que es el objetivo de esta prueba,
            // todos los demas parametros se llenaran con cadenas vacias "", 0 o valores de ejemplo
            foreach ( string nombresPersona in nombres ) 
            { 
                listaPersonasConstructor.Add( new ClsEstudiante(  
                                                                    idEstudiante: 0, 
                                                                    idCarrera: 0,
                                                                    cedula: "",
                                                                    semestre: 1,
                                                                    contrasenia: "",
                                                                    id_rol_usuario: 0,
                                                                    nombres: nombresPersona,
                                                                    apellidos: ""
                                                                ) ); 
            }

            foreach ( string nombresPersona in nombres )
            {
                listaPersonasConstructor.Add( new ClsCandidata(
                                                                    idCandidata: 0,
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
                                                                    habilidades: ""
                                                                ) );
            }

            // Prueba usando la Propiedad
            foreach ( string nombresP in nombres ) { listaPersonasPropiedad.Add( new ClsEstudiante() { Nombres = nombresP } ); }
            foreach ( string nombresP in nombres ) { listaPersonasPropiedad.Add( new ClsCandidata() { Nombres = nombresP } ); }

            // *****
            // ***** Assert - Afirmación
            // *****

            for( int i = 0; i < primerNombre.Length; i++ ) 
            {
                Assert.Equal( expected: primerNombre[ i ], actual: listaPersonasConstructor[ i ].PrimerNombre );
                Assert.Equal( expected: primerNombre[ i ], actual: listaPersonasPropiedad[ i ].PrimerNombre );
            }

            for ( int i = 0; i < segundoNombre.Length; i++ )
            {
                Assert.Equal( expected: segundoNombre[ i ], actual: listaPersonasConstructor[ i ].SegundoNombre );
                Assert.Equal( expected: segundoNombre[ i ], actual: listaPersonasPropiedad[ i ].SegundoNombre );
            }

        }
    }
}
