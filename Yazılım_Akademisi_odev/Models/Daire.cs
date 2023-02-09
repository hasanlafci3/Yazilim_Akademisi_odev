using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Yazılım_Akademisi_odev.Models
{
    public class Daire
    {
        [Key]
        public int Id { get; set; }
        public int Daire_no { get; set; }
        public string Block { get; set; }
        public string Durumu { get; set; }
        public string Tip { get; set; }
        public int Kat { get; set; }
        public string Oturan { get; set; } // kiracı yada mülk sahibi
         
        [Required]
        public string Name { get; set; }  // Daire sahibi adi
        public int Tc { get; set; }  // Daire sahibi soyadi
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Arac { get; set; }
        


    }
}

