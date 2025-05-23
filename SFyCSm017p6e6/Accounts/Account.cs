using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm017p6e6.Accounts;

/// <summary>
/// Базовый класс определяющий описание учетной записи.
/// </summary>
public abstract class Account
{
    /// <summary>
    /// Тип учетной записи
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Баланс учетной записи
    /// </summary>
    public double Balance { get; set; }

    /// <summary>
    /// Процентная ставка
    /// </summary>
    public double Interest { get; set; }

    /// <summary>
    /// Выводит информацию об учётной записи.
    /// </summary>
    public void ShowInfo()
    {
        Console.WriteLine($"Тип учетной записи: {Type}\n% ставка: {Interest}\nбаланс: {Balance}");
    }

    /// <summary>
    /// Абстрактный метод для расчета процентной ставки
    /// </summary>
    public abstract void CalculateInterest();

}
