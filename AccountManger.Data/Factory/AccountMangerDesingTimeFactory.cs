using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data.Factory
{
    public class AccountMangerDesingTimeFactory
           : IDesignTimeDbContextFactory<AccountManagerDBContex>
        {

        public AccountManagerDBContex CreateDbContext(string[] args)
        {
            var optionBuider = new DbContextOptionsBuilder<AccountManagerDBContex>();

            optionBuider.UseSqlServer(@"Server=DESKTOP-BI9HP3L; DataBase=AccountManagerDB; Integrated Security=true");
            return new AccountManagerDBContex(optionBuider.Options);

        }

   }
}
