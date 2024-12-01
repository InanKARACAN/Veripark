using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veripark.Data.UnitOfWorks;
using Veripark.Entity.Entities;
using Veripark.Service.Services.Abstractions;

namespace Veripark.Service.Services.Concretes
{
    public class OlayTipService: IOlayTipService
    {
        private readonly IUnitOfWork unitOfWork;

        public OlayTipService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<OlayTip>> GetAllOlayTipAsync()
        {
            return await unitOfWork.GetRepository<OlayTip>().GetAllAsync();
        }
    }
}
