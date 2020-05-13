using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // Customer = login + password + passport data + deposits
    [Serializable]
    public class Customer
    {
        public List<Deposit> Deposits { get; private set; }
        private string accountNumber;
        private const int PASSWORD_MIN_LENGTH = 6;
        private const int ACCOUNT_NUMBER_LENGTH = 9;

        public Customer(
            string login,
            string password,
            string fullName,
            string accountNumber,
            string address,
            DateTime birthDate
        )
        {
            Login = login;
            Password = password;
            FullName = fullName;
            AccountNumber = accountNumber.ToString();
            Address = address;
            BirthDate = birthDate;
            Deposits = new List<Deposit>();
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                while (value.Length < ACCOUNT_NUMBER_LENGTH)
                {
                    value = value.Insert(0, "0");
                }
                accountNumber = value;
            }
        }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public void Copy(Customer source)
        {
            Login = source.Login;
            Password = source.Password;
            FullName = source.FullName;
            AccountNumber = source.AccountNumber;
            Address = source.Address;
            BirthDate = source.BirthDate;
        }

        public void Change(Customer data)
        {
            data.CheckData();

            // If no exceptions - change customer data

            Copy(data);
        }

        public void CheckData()
        {
            // Check login
            if (Login.Length == 0)
            {
                throw new InputException("Логин не может быть пустым!");
            }
            for (int i = 0; i < Login.Length; i++)
            {
                if (char.IsWhiteSpace(Login[i]))
                {
                    throw new InputException("Логин не может содержать пробелов!");
                }
            }

            // Check password

            if (Password.Length < PASSWORD_MIN_LENGTH)
            {
                throw new InputException("Пароль должен быть не меньше 6 символов!");
            }

            // Check full name

            if (FullName.Length == 0)
            {
                throw new InputException("Имя не может быть пустым!");
            }
            for (int i = 0; i < FullName.Length; i++)
            {
                char ch = FullName[i];
                if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch))
                {
                    throw new InputException("Имя может содержать только буквы!");
                }
            }

            // Check account number

            if (AccountNumber.Length > ACCOUNT_NUMBER_LENGTH)
            {
                throw new InputException("Неправильный номер счета!");
            }

            // Check birth date

            if (BirthDate >= DateTime.Now)
            {
                throw new InputException("Неправильная дата!");
            }
        }
    }
}
