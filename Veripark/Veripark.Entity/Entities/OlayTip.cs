using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veripark.Entity.Entities
{
    public class OlayTip: EntityBase
    {
        public string OlayTipAdi { get; set; }
        public Guid OlayOncelikId { get; set; }
        public OlayOncelik OlayOncelik { get; set; }
    }
}