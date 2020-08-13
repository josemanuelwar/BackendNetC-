namespace Dominio
{
    public class EJERCIOS
    {
        public int ID_EJERCIO {get; set;}
        public string NOMBRE_DEL_EJERCICIO {get; set;}
        /**relacion con la tabla de ejecicio en temas*/
        public int TEMA_ID {get; set;}
        public TEMAS tema {get; set;}

        public ICollection<RESPUESTA> respuestalista {get; set;}
        public ICollection<RESPUESTA_ALUMNOS> resps_alum {get; set;}
    }
}