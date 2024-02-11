using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Services.EncryptersDictionaries
{
    internal class ReverseEncrypter
    {
        private readonly Dictionary<char, char> _encrypters = new Dictionary<char, char>();

        public ReverseEncrypter()
        {
            _encrypters.Add('0', '5');
            _encrypters.Add('1', '6');
            _encrypters.Add('2', '7');
            _encrypters.Add('3', '8');
            _encrypters.Add('4', '9');
            _encrypters.Add('5', '0');
            _encrypters.Add('6', '1');
            _encrypters.Add('7', '2');
            _encrypters.Add('8', '3');
            _encrypters.Add('9', '4');
            _encrypters.Add('A', 'N');
            _encrypters.Add('B', 'O');
            _encrypters.Add('C', 'P');
            _encrypters.Add('D', 'Q');
            _encrypters.Add('E', 'R');
            _encrypters.Add('F', 'S');
            _encrypters.Add('G', 'T');
            _encrypters.Add('H', 'U');
            _encrypters.Add('I', 'V');
            _encrypters.Add('J', 'W');
            _encrypters.Add('K', 'X');
            _encrypters.Add('L', 'Y');
            _encrypters.Add('M', 'Z');
            _encrypters.Add('N', 'A');
            _encrypters.Add('O', 'B');
            _encrypters.Add('P', 'C');
            _encrypters.Add('Q', 'D');
            _encrypters.Add('R', 'E');
            _encrypters.Add('S', 'F');
            _encrypters.Add('T', 'G');
            _encrypters.Add('U', 'H');
            _encrypters.Add('V', 'I');
            _encrypters.Add('W', 'J');
            _encrypters.Add('X', 'K');
            _encrypters.Add('Y', 'L');
            _encrypters.Add('Z', 'M');

        }

        public char GetValue(char input)
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

        
    }
}
