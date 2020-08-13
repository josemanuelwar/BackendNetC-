namespace Dominio
{
    public class TEMAS
    {
        public int ID_TEMAS {get; set;}
        public string NOMBRE_TEMA {get; set;}
        public string NIVEL_TEMA {get; set;}
        /**relacion que exite en la tabla temas a materia*/
        public int MATERIA_ID {get; set;}
        public MATERIA materia {get; set;}
    }
}