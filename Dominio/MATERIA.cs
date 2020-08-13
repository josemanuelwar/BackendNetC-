using system.Collections.Generic;

namespace Dominio
{
    public class MATERIA
    {
        public int ID_MATERIA {get; set;}
        public string NOMBRE_MATERIA {get; set;}
        /**relaciomanos la tabla profesor con la tabla */
        public int PROFESOR_ID {get; set;}
        public USUARIOS profesor {get; set;}

        public ICollection<EJERCIOS> ejerciciolista {get; set;}

    }
}