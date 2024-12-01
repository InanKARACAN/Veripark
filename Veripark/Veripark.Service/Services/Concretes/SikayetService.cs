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
    public class SikayetService: ISikayetService
    {
        private readonly IUnitOfWork unitOfWork;

        public SikayetService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> SikayetEkle(Sikayet sikayet)
        {
            try
            {
                await unitOfWork.GetRepository<Sikayet>().AddAsync(sikayet);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
