using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veripark.Entity.Entities
{
    public class Sikayet: EntityBase
    {
        [DisplayName("Olay Tipi")]
        public Guid OlayTipi { get; set; }
        [DisplayName("Müşteri Tipi")]
        public Guid MusteriTipi { get; set; }
        [DisplayName("Olay Zamanı")]
        public DateTime OlayZamani { get; set; }
        [DisplayName("Müşteri Adi")]
        public string MusteriAdi{ get; set; }
        public string CepTelefonu{ get; set; }
        public int MaxVerilenSure { get; set; }
    }
}