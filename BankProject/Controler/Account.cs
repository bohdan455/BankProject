using System;
using System.Collections.Generic;
using System.Text;
using BankProject.Model;
namespace BankProject.Controler
{
    delegate void Value(string text);
    
    class Account: IAccountController
    {
        event Value GetText;
        event Value SetText;
        AccountModel data;
        public Account(int id, int balance, int days) { data = new AccountModel(id, balance, days); }
        
        public void GetBalance()
        {
            GetText($"Баланс: {data.Balance}");
        }

        public void SetBalance(int balance)
        {
            data.Balance = balance;
            SetText($"Аккаунт пополнен на {balance} рублей. Сейчас на балансе {data.Balance}");
        }

        
    }
}
