using System.Collections.Generic;

namespace BankProject.Controler
{
    class BankSetting : IBankSetting
    {
        List<Account> accounts = new List<Account>();
        public void CreateAccount(int id, int balance, int days)
        {
            accounts.Add(new Account(id, balance, days));
        }

        public void DeleteAccount()
        {
            accounts.IndexOf(
        }

        public void NextDay()
        {

        }
    }
}
