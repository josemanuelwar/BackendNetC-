using System.Collections.Generic;
namespace Dominio
{
    public class PAIS
    {
        public int ID_PAIS {get; set;}
        public string NOMBRE_PAIS {get; set;}
        public ICollection<ESCUELA> esculalistas {get; set;}
    }
}