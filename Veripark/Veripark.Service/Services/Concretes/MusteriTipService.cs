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
    public class MusteriTipService: IMusteriTipService
    {
        private readonly IUnitOfWork unitOfWork;

        public MusteriTipService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<MusteriTip>> GetAllMusteriTipAsync()
        {
            return await unitOfWork.GetRepository<MusteriTip>().GetAllAsync();
        }
    }
}
