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
        // String, displayed on Customers list
        public string InfoString
        {
            get
            {
                return Login + "   (" + FullName + ")";
            }
        }

        public void Change(
            string login,
            string password,
            string fullName,
            string accountNumber,
            string address,
            DateTime birthDate
        )
        {
            CheckData(login, password, fullName, accountNumber, address, birthDate);

            // If no exceptions - change customer data

            Login = login;
            Password = password;
            FullName = fullName;
            AccountNumber = accountNumber.ToString();
            Address = address;
            BirthDate = birthDate;
        }

        private static void CheckData(
            string login,
            string password,
            string fullName,
            string accountNumber,
            string address,
            DateTime birthDate
        )
        {
            // Check login
            if (login.Length == 0)
            {
                throw new Exception("Логин не может быть пустым!");
            }
            for (int i = 0; i < login.Length; i++)
            {
                if (char.IsWhiteSpace(login[i]))
                {
                    throw new Exception("Логин не может содержать пробелов!");
                }
            }

            // Check password

            if (password.Length < PASSWORD_MIN_LENGTH)
            {
                throw new Exception("Пароль должен быть не меньше 6 символов!");
            }

            // Check full name

            if (fullName.Length == 0)
            {
                throw new Exception("Имя не может быть пустым!");
            }
            for (int i = 0; i < fullName.Length; i++)
            {
                char ch = fullName[i];
                if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch))
                {
                    throw new Exception("Имя может содержать только буквы!");
                }
            }

            // Check account number

            if (accountNumber.Length > ACCOUNT_NUMBER_LENGTH)
            {
                throw new Exception("Неправильный номер счета!");
            }

            // Check birth date

            if (birthDate >= DateTime.Now)
            {
                throw new Exception("Неправильная дата!");
            }
        }
    }
}
