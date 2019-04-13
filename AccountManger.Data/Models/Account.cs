using AccountManger.Data.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data.Models 
{
   public class Account: ModelBase<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }



        public AccountType AccountType { get; set; }
        public int AccountTypeId { get; set; }

     



    }
}
