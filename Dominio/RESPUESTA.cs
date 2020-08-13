using system.Collections.Generic;
namespace Dominio
{
    public class RESPUESTA
    {
        public int ID_RESPUESTA { get; set; }
        public string ENUCIADO_RESPUESTA {get; set;}
        public string RESPUESTA_CORRECTA {get; set;}
        /**ralizo la realcion tabla ejecicio y respuestas*/
        public int EJERCIO_ID {get; set;}
        public EJERCIOS ejercio {get; set;}
        
        public ICollection<RESPUESTA_ALUMNOS> repues_alum {get; set;}
    }
}