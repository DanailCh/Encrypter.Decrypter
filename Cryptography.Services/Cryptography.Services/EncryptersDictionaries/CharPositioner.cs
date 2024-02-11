using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Services.EncryptersDictionaries
{
    internal class CharPositioner
    {
        private readonly Dictionary<char, int> _encrypters = new Dictionary<char, int>();
        public CharPositioner()
        {
            _encrypters.Add('A', 1);
            _encrypters.Add('B', 2);
            _encrypters.Add('C', 3);
            _encrypters.Add('D', 4);
            _encrypters.Add('E', 5);
            _encrypters.Add('F', 6);
            _encrypters.Add('G', 7);
            _encrypters.Add('H', 8);
            _encrypters.Add('I', 9);
            _encrypters.Add('J', 10);
            _encrypters.Add('K', 11);
            _encrypters.Add('L', 12);
            _encrypters.Add('M', 13);
            _encrypters.Add('N', 14);
            _encrypters.Add('O', 15);
            _encrypters.Add('P', 16);
            _encrypters.Add('Q', 17);
            _encrypters.Add('R', 18);
            _encrypters.Add('S', 19);
            _encrypters.Add('T', 20);
            _encrypters.Add('U', 21);
            _encrypters.Add('V', 22);
            _encrypters.Add('W', 23);
            _encrypters.Add('X', 24);
            _encrypters.Add('Y', 25);
            _encrypters.Add('Z', 26);
        }

        public int GetPosition(char input)
        {
            if (_encrypters.ContainsKey(input))
            {
                return _encrypters[input];
            }
            else
            {
                throw new InvalidOperationException("Char not supported");
            }
        }
        public char GetChar(int input)
        {
            if (_encrypters.ContainsValue(input))
            {
                var item = _encrypters.FirstOrDefault(i => i.Value == input);
                return item.Key;
            }
            else
            {
                throw new InvalidOperationException("String not in dictionary");
            }
        }
    }
}
