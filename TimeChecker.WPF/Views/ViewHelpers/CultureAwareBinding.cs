using System.Globalization;
using System.Windows.Data;

namespace TimeChecker.WPF.Views.ViewHelpers
{
    public class CultureAwareBinding : Binding
    {
        public CultureAwareBinding()
        {
            ConverterCulture = CultureInfo.GetCultureInfo("ru-RU");
        }
    }
}
