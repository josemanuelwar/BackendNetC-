using system.Collections.Generic;
namespace Dominio
{
    public class ESCUELA
    {
        public int ID_ESCUELA { get; set; }
        public string NOMBRE_ESCUELA { get; set; }
        public string CLAVE_ESCUELA { get; set; }
        public string DIRECCION { get; set; }
        /**relacionamos  municipio*/
        public int MUNICIPIO_ID { get; set; }
        public MUNICIPIO municipio { get; set; }
        /**relacionamos con lo de estado*/
        public int ESTADO_ID { get; set; }
        public ESTADO estado { get; set; }
        /**relacionamos con los paise*/
        public int PAIS_ID { get; set; }
        public PAIS pais { get; set; }

        /**colecition*/
        public ICollection<USUARIOS> usuariosLista {get; set;}
    }
}