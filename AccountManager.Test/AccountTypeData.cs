using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountManger.Data.Factory;
using AccountManger.Data;

namespace AccountManager.Test
{
    [TestClass]
    public class AccountTypeData
    {

        private AccountManagerDBContex contex;



        public AccountTypeData()
        {

            var factory = new AccountMangerDesingTimeFactory();
            contex = factory.CreateDbContext(new string[] { });

        }








        [TestMethod]
        public void AddOk()
        {

            
        }
    }
}
