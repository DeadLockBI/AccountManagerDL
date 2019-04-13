using AccountManger.Data.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data.Models
{
   public class AccountType: ModelBase<int>
    {

        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }


    }
}
