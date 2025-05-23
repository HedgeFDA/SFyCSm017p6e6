using SFyCSm017p6e6.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm017p6e6.Accounts;

/// <summary>
/// Наследник класса <see cref="Account"/>.
///     Определяет описание зарплатной учетной записи.
/// </summary>
public class SalaryAccount : Account
{
    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public SalaryAccount()
    {
        Type = "Зарплатный";
    }

    /// <summary>
    /// Переопределение метода <see cref="Account.CalculateInterest()"/> для расчета процентной ставки.
    /// </summary>
    /// <param name="account">Учетная запись.</param>
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}
