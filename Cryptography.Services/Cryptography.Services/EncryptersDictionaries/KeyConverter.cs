using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Services.EncryptersDictionaries
{
    internal class KeyConverter
    {
        private readonly Dictionary<char, int> _encrypters = new Dictionary<char, int>();

        public KeyConverter()
        {
            _encrypters.Add('a', 1);
            _encrypters.Add('b', 2);
            _encrypters.Add('c', 3);
            _encrypters.Add('d', 4);
            _encrypters.Add('e', 5);
            _encrypters.Add('f', 6);
            _encrypters.Add('g', 7);
            _encrypters.Add('h', 8);
            _encrypters.Add('i', 9);
            _encrypters.Add('j', 10);
            _encrypters.Add('k', 11);
            _encrypters.Add('l', 12);
            _encrypters.Add('m', 13);
            _encrypters.Add('n', 14);
            _encrypters.Add('o', 15);
            _encrypters.Add('p', 16);
            _encrypters.Add('q', 17);
            _encrypters.Add('r', 18);
            _encrypters.Add('s', 19);
            _encrypters.Add('t', 20);
            _encrypters.Add('u', 21);
            _encrypters.Add('v', 22);
            _encrypters.Add('w', 23);
            _encrypters.Add('x', 24);
            _encrypters.Add('y', 25);
            _encrypters.Add('z', 26);
            _encrypters.Add('0', 0);
            _encrypters.Add('1', 1);
            _encrypters.Add('2', 2);
            _encrypters.Add('3', 3);
            _encrypters.Add('4', 4);
            _encrypters.Add('5', 5);
            _encrypters.Add('6', 6);
            _encrypters.Add('7', 7);
            _encrypters.Add('8', 8);
            _encrypters.Add('9', 9);

        }

        public string ConvertKey(string key)
        {
            var sb=new StringBuilder();
            foreach (char c in key.ToLower())
            {
                if (_encrypters.ContainsKey(c))
                {
                    sb.Append(_encrypters[c].ToString());
                }
                else
                {
                    throw new InvalidOperationException("Char not supported");
                }
            }
            return sb.ToString();
        }
    }
}
