using system.Collections.Generic;
namespace Dominio
{
    public class MUNICIPIO
    {
        public int ID_MUNICIPIO { get; set;}
        public string NOMBRE_MUNICIPIO {get; set;}

        public ICollection<ESCUELA> escuelalista {get; set;}
    }
}