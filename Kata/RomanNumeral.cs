using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    /*Then I created a class to implement the same interface. 
  the method names are same as interface method and all the methods are pubic default .*/
  public  class RomanNumeral:IRomanNumeralGenerator
    {
        private string _romanNumeral = string.Empty;
		private readonly IDictionary<int, string> _mappings = new Dictionary<int, string>();
        private int num;
		public RomanNumeral ()
		{
            //Roman Numerals, as used today, are based on seven symbols
			_mappings.Add (1000, "M");
            _mappings.Add(900, "CM");
			_mappings.Add (500, "D");
            _mappings.Add(400, "CD");
			_mappings.Add (100, "C");
            _mappings.Add(90, "XC");
			_mappings.Add (50, "L");
            _mappings.Add(40, "XL");
			_mappings.Add (10, "X");
            _mappings.Add (9, "IX");
			_mappings.Add (5, "V");
            _mappings.Add(4, "IV");
			_mappings.Add (1, "I");
		}
        public RomanNumeral(int num)
        {
            // TODO: Complete member initialization
            this.num = num;
        }
		// Explicit interface member implementation:  
        public string Generate(int arabicNumeral)
		{						
			foreach (var mapping in _mappings)
			{
				arabicNumeral = ParseMultiples(arabicNumeral, mapping);
			}
			
			for (int i = 0; i < arabicNumeral; i++)
				_romanNumeral += "I";			
			
			return _romanNumeral;
		}
      /// <summary>
      /// This function contain two parameter and it gives the output as integer.Its used for generate number
      /// </summary>
      /// <param name="arabicNumeral"></param>
      /// <param name="mapping"></param>
      /// <returns></returns>
		private int ParseMultiples(int arabicNumeral, KeyValuePair<int,string> mapping)
		{
			var noMultiples = arabicNumeral / mapping.Key;
			for (int i = 0; i < noMultiples; i++)
			{
				_romanNumeral += mapping.Value;
			}
			
			return  arabicNumeral -(noMultiples * mapping.Key);
		}

        public int Generate()
        {
            throw new NotImplementedException();
        }

        public object Parse(int p)
        {
            throw new NotImplementedException();
        }
    }  
}
