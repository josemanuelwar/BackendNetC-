using system.Collections.Generic;
namespace Dominio
{
    public class USUARIOS
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string EMAIL_USUARIO { get; set; }
        public int GRADO {get; set;}
        /**relacionamos la tabla escuela con la de usuario*/
        public int ESCUELA_ID { get; set; }
        public ESCUELA escuela { get; set; }
        /**relacionamos la tabla Rol con la tabla usuario*/
        public int ROL_ID { get; set; }
        public ROLES roles { get; set; }
        /** colecion */
        public ICollection<MATERIA> materia {get; set;}

        public ICollection<RESPUESTA_ALUMNOS> resp_alumnos {get; set;}

    }
}