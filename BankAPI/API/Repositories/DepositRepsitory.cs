using API.Data;
using API.Data.Entity;
using API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class DepositRepsitory : IDepositRepository
    {
        public readonly ApplicationDbContext _context;

        public DepositRepsitory(ApplicationDbContext context)
        {
            _context = context;
        }

        public int DepositMoney(DepositDto payload)
        {
            Deposit dep = new Deposit
            {
                Amount = payload.Amount,
                UserId = payload.UserId
            };
            _context.Deposit.Add(dep);
            _context.SaveChanges();
            return dep.Id;
        }
    }
}
