using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data.Models.Core
{
public  class AccountTyoeDataService
        : DataServicesBase<AccountType,AccountManagerDBContex>
        {

        public AccountTyoeDataService(IMapper mapper, AccountManagerDBContex contex)
            : base(mapper, contex)
        {

        }



    }
}
