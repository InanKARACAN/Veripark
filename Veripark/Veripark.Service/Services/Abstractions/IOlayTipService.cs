using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veripark.Entity.Entities;

namespace Veripark.Service.Services.Abstractions
{
    public interface IOlayTipService
    {
        Task<List<OlayTip>> GetAllOlayTipAsync();
    }
}