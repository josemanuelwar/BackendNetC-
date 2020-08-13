using System.Collections.Generic;
namespace Dominio
{
    public class ESTADO
    {
        public int ID_ESTADO {get; set;}
        public string NOMBRE_ESTADO {get; set;}
        public ICollection<ESCUELA> ESCUELALISTA {get; set;}
    }
}