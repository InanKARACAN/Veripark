using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veripark.Entity.Entities
{
    public class OlayOncelik: EntityBase
    {
        public string OlayOncelikAdi { get; set; }
        public int MaxCozumSuresi { get; set; }
        public ICollection<OlayTip> OlayTipleri { get; set; }

    }
}