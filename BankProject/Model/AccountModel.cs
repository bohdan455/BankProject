using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Model
{
    class AccountModel
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public int Days { get; set; }
        public AccountModel(int id, int balance, int days) { Id = id; Balance = balance; Days = days; }
    }
}
