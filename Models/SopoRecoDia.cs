using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspStudio.Models
{
    
    [Table("SOPO_RECON_DIAS")]
    public class SopoRecoDia
    {
        [Column("Fecha")]
        public String Fecha {get; set;}

        [Column("time")]
        public DateTime DateTime {get; set;}

        [Column("documento")]
        public String DocId {get; set;}

        [Column("name")]
        public String Name {get; set;}

        [Column("empresa")]
        public String Empresa {get; set;}

        [Column("device_id")]
        public String DevId {get; set;}

        [Column("ciudad_registro")]
        public String Ciudad {get; set;}

        [Column("sitio_registro")]
        public String Sitio {get; set;}

        [Column("pta_lenel")]
        public String Puerta {get; set;}

        [Column("similar")]
        public Double Similar {get; set;}

        [Column("temperature")]
        public Double Temperature {get; set;}

        
    }
}