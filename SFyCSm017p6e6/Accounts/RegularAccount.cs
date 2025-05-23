using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm017p6e6.Accounts;

/// <summary>
/// Наследник класса <see cref="Account"/>.
///     Определяет описание обычной учетной записи.
/// </summary>
public class RegularAccount : Account
{
    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public RegularAccount()
    {
        Type = "Обычный";
    }

    /// <summary>
    /// Переопределение метода <see cref="Account.CalculateInterest()"/> для расчета процентной ставки.
    /// </summary>
    /// <param name="account">Учетная запись.</param>
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;
        else if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}
