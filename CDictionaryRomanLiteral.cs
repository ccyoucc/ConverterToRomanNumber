using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterToRomanNumber
{
    /// <summary>
    /// one instance class for managing the dictionary of roman literal
    /// </summary>
    public class CDictionaryRomanLiteral : IDictionary<ushort, string>
    {
        #region members
        private static CDictionaryRomanLiteral dictionaryInstance = null;
        private Dictionary<ushort, string> listRomanLiterals = null;
        #endregion
        

        #region private constructor
        /// <summary>
        /// private constructor to avoid multiple instances of the list
        /// </summary>
        private CDictionaryRomanLiteral()
        {
            listRomanLiterals = new Dictionary<ushort, string>();
            listRomanLiterals.Add(1, "I");
            listRomanLiterals.Add(4, "IV");
            listRomanLiterals.Add(5, "V");
            listRomanLiterals.Add(9, "IX");
            listRomanLiterals.Add(10, "X");
            listRomanLiterals.Add(40, "XL");
            listRomanLiterals.Add(50, "L");
            listRomanLiterals.Add(90, "XC");
            listRomanLiterals.Add(100, "C");
            listRomanLiterals.Add(400, "CD");
            listRomanLiterals.Add(500, "D");
            listRomanLiterals.Add(900, "CM");
            listRomanLiterals.Add(1000, "M");
        }
        #endregion

        #region public static methods
        /// <summary>
        /// method used to have access to the dictionary
        /// </summary>
        /// <returns></returns>
        public static CDictionaryRomanLiteral GetInstance()
        {
            if (dictionaryInstance == null)
                dictionaryInstance = new CDictionaryRomanLiteral();
            return dictionaryInstance;
        }
        #endregion

        #region IDictionary
        public string this[ushort key] { get => listRomanLiterals[key]; set => throw new NotSupportedException("Access violation"); }

        public ICollection<ushort> Keys { get => listRomanLiterals.Keys; }

        public ICollection<string> Values { get => listRomanLiterals.Values; }

        public int Count { get => listRomanLiterals.Count; }

        public bool IsReadOnly => throw new NotImplementedException();


        public void Add(ushort key, string value)
        {
            throw new NotSupportedException("Access violation");
        }

        public void Add(KeyValuePair<ushort, string> item)
        {
            throw new NotSupportedException("Access violation");
        }

        public void Clear()
        {
            throw new NotSupportedException("Access violation");
        }

        public bool Contains(KeyValuePair<ushort, string> item)
        {
            throw new NotSupportedException("Access violation");
        }

        public bool ContainsKey(ushort key)
        {
            throw new NotSupportedException("Access violation");
        }

        public void CopyTo(KeyValuePair<ushort, string>[] array, int arrayIndex)
        {
            throw new NotSupportedException("Access violation");
        }

        public IEnumerator<KeyValuePair<ushort, string>> GetEnumerator()
        {
            throw new NotSupportedException("Access violation");
        }

        public bool Remove(ushort key)
        {
            throw new NotSupportedException("Access violation");
        }

        public bool Remove(KeyValuePair<ushort, string> item)
        {
            throw new NotSupportedException("Access violation");
        }

        public bool TryGetValue(ushort key, out string value)
        {
            throw new NotSupportedException("Access violation");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException("Access violation");
        }
        #endregion
    }
}
