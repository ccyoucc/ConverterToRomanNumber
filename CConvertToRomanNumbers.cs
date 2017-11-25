using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterToRomanNumber
{
    /// <summary>
    /// convert a number into it's roman literals representation
    /// </summary>
    class CConvertToRomanNumbers
    {
        #region members
        private Stack<ushort> _romanNumbers = null;
        #endregion
        #region properties
        /// <summary>
        /// a stack witch contains the ordered roman numbers, with the smallest one to the bottom 
        /// </summary>
        private Stack<ushort> romanNumbers
        {
            get => _romanNumbers ?? (_romanNumbers = new Stack<ushort>(CDictionaryRomanLiteral.GetInstance().Keys));
        }
        #endregion

        #region public methods
        public string Convert(ushort number)
        {
            StringBuilder result = new StringBuilder();
            foreach (IEnumerable<string> groupRomanLiteral in ConvertFromNumberToRomanString(number))
            {
                foreach (string romanLiteral in groupRomanLiteral)
                {
                    result.Append(romanLiteral);
                }
            }            
             return result.ToString();
        }
        #endregion

        #region private methods
        /// <summary>
        /// creates a list with all the roman literals
        /// </summary>
        /// <param name="number">the number to transform</param>
        /// <returns>a list with roman literals</returns>
        private IEnumerable<IEnumerable<string>> ConvertFromNumberToRomanString(ushort number)
        {
            ushort repeat = 0;
            ushort romanNumber = 0;
            //take each roman number from the stack
            romanNumber = romanNumbers.Pop();
            while (number > 0)
            {
                //verify if it is included in our number
                repeat = (ushort)(number / romanNumber);
                //if not, then go to next number
                if (repeat == 0)
                    romanNumber = romanNumbers.Pop();
                //if yes, then verify how many times 
                else
                {
                    number %= romanNumber;
                    //create a list with the roman literal repeated several times
                    yield return CDictionaryRomanLiteral.GetInstance()[romanNumber].Repeat(repeat);
                }
            }
        }

        #endregion
    }

}
