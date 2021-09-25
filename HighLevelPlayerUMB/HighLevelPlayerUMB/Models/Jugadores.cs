using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HighLevelPlayerUMB.Models
{
    public class Jugadores
    {
        [Key]
        public int id { get; set; }

        public string pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Club { get; set; }
        public int Estatura { get; set; }
        public int Edad { get; set; }
    }
}
