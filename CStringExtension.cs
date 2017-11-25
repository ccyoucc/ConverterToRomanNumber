using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterToRomanNumber
{
    /// <summary>
    /// static class used to extend the string class functionalities
    /// </summary>
    public static class CStringExtension
    {
        /// <summary>
        /// repeat a literal the desired number of times
        /// </summary>
        /// <param name="str">the roman literal</param>
        /// <param name="nbRepeat">the number of repetitions</param>
        /// <returns>returns a list with the repeated literals</returns>
        public static IEnumerable<string> Repeat(this string str, ushort nbRepeat)
        {
            for (int nb = 0; nb < nbRepeat; ++nb)
                yield return str;
        }
        /// <summary>
        /// convert a string number into a ushort type
        /// </summary>
        /// <param name="str"></param>
        /// <returns>returns a ushort type number</returns>
        public static ushort ToUShort(this string str)
        {
            try
            {
                return (ushort)Convert.ToInt16(str);
            }
            catch
            {
                throw new NotSupportedException("The supplied information is not a valid number");
            }
        }
        /// <summary>
        /// convert a string number into the corresponding roman number
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return the string with the roman number representation</returns>
        public static string ConvertToRomanLiterals(this string str)
        {
            ushort val = str.ToUShort();
            if (val < 1 && val > 4999)
                throw new NotSupportedException("The supplied number must be between 1 and 4999");
            return new CConvertToRomanNumbers().Convert(str.ToUShort());
        }
    }
}
