using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Controler
{
    interface IBankSetting
    {
        void CreateAccount(int balance, int days);
        void DeleteAccount();
        void NextDay();

    }
}
