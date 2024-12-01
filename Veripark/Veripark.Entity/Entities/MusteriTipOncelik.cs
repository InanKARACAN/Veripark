using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veripark.Entity.Entities
{
    public class MusteriTipOncelik : EntityBase
    {
        public ICollection<OlayOncelik> OlayOncelikler { get; set; }
        public ICollection<MusteriTip> MusteriTipler { get; set; }
        
    }
}