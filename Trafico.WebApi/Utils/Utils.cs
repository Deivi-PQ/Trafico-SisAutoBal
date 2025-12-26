using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Trafico.WebApi.Utils
{
    public partial class Utils
    {
        public Int64 ToDecimalAuto(string input)
        {
            Int64 result = 0;
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Trim();

            // Regla 1: Si empieza con 0x → Hex
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                input = input.Substring(2);
                result = Convert.ToInt64(input, 16);
            }

            // Regla 2: Si son solo dígitos Y longitud = 7 → Decimal
            if (input.All(char.IsDigit) && input.Length == 7)
            {
                result = int.Parse(input, CultureInfo.InvariantCulture);
            }

            // Regla 3: Si contiene letras A–F → Hex
            if (input.Any(c => "ABCDEFabcdef".Contains(c)))
            {
                result = Convert.ToInt64(input, 16);
            }

            // Regla 4: Solo dígitos pero longitud != 7 → Hex
            if (input.All(char.IsDigit))
            {
                result = Convert.ToInt64(input, 16);
            }

            return result;
        }
    }
}
