﻿using API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{


    public interface IDepositRepository
    {
        public int DepositMoney(DepositDto payload);

    }
}
