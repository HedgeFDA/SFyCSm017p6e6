using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SFyCSm017p6e6.Accounts;

namespace SFyCSm017p6e6;

class Program
{
    /// <summary>
    /// Процедура реализующая основной алгоритм работы программы.
    /// </summary>
    static void PerformMain()
    {
        var regularAccount = new RegularAccount();
        regularAccount.Balance = 1;
        regularAccount.CalculateInterest();
        regularAccount.ShowInfo();

        var salaryAccount = new SalaryAccount();
        salaryAccount.Balance = 1;
        salaryAccount.CalculateInterest();
        salaryAccount.ShowInfo();
    }

    /// <summary>
    /// Главная точка входа приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки при запуске приложения.</param>
    static void Main(string[] args)
    {
        PerformMain();
    }
}