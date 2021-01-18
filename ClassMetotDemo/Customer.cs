using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class Customer
    {
        public Customer(int ıd, string name, string surname, int birthyear, int balance, int creditScore, string password)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Birthyear = birthyear;
            Balance = balance;
            CreditScore = creditScore;
            Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Birthyear { get; set; }
        public int Balance { get; set; }
        public int CreditScore { get; set; }

        public string Password { get; set; }
    }
}
