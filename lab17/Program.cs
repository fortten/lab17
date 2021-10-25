using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
     *Класс должен быть обобщенным. Универсальный параметр Т определяет тип номера счета. Разработать методы для доступа к
     *данным - заполнения и чтения. Создать несколько экземпляров класса с различными типами. Заполнить его поля и вывести
     *информацию об экземпляре класса на печать.*/
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bAcc1 = new BankAccount<int>();
            bAcc1.InputData(254832, 734628.78, "Иванов Петр Дмитриевич");
            bAcc1.ShowData();
            Console.WriteLine();

            BankAccount<string> bAcc2 = new BankAccount<string>();
            bAcc2.InputData("685334", 533980.24, "Петров Михаил Андреевич");
            bAcc2.ShowData();
            Console.WriteLine();

            BankAccount<double> bAcc3 = new BankAccount<double>();
            bAcc3.InputData(721963, 628377.82, "Михайлова Ксения Николаевна");
            bAcc3.ShowData();
            Console.WriteLine();

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        private T account;
        private double balance;
        private string owner;

        public void InputData(T account, double balance, string owner)
        {
            this.account = account;
            this.balance = balance;
            this.owner = owner;
        }

        public void ShowData()
        {
            Console.WriteLine("Номер счета: {0}", account);
            Console.WriteLine("ФИО владельца счета: {0}", owner);
            Console.WriteLine("Баланс счета: {0}", balance);            
        }
    }
}
