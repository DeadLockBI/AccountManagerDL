using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data.Models.Core
{
   public class AccountDataServices 
        : DataServicesBase<AccountDataServices, AccountManagerDBContex>
                      {

        public AccountDataServices(IMapper mapper, AccountManagerDBContex contex)
       : base(mapper, contex)
        {

        }

    }
   }

   