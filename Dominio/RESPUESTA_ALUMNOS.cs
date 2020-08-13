namespace Dominio
{
    public class RESPUESTA_ALUMNOS
    {
        /**relacionamos la tabla respuesto*/
        public int RESPUESTA_ID {get;set;}
        public RESPUESTA respuesta {get; set;}
        /**relacionamos la tabla de ejercisio*/
        public int EJERCIO_ID {get; set;}
        public EJERCIOS ejeccio {get; set;}
        /**relacinamos a los alumnos*/
        public int ALUMNO_ID {get; set;}
        public USUARIOS alumnos {get; set;}
    }
}