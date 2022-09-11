using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HealthDataFinder.Domain.Extensions
{
    public class Mask
    {
        public static string UnmaskOnlyNumbers(string value)
        {
            Regex digitsOnly = new(@"[^\d]");
            return digitsOnly.Replace(value, "");
        }
    }
}
