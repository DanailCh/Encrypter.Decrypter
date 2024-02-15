using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Services.EncryptersDictionaries
{
    internal class AsciiEncrypter
    {
        private readonly Dictionary<char, string> _encrypters=new Dictionary<char, string>();

        public AsciiEncrypter()
        {
            _encrypters.Add(' ', "20");
            _encrypters.Add('!', "21");
            _encrypters.Add('"', "22");
            _encrypters.Add('#', "23");
            _encrypters.Add('$', "24");
            _encrypters.Add('%', "25");
            _encrypters.Add('&', "26");
            _encrypters.Add('\'', "27");
            _encrypters.Add('(', "28");
            _encrypters.Add(')', "29");
            _encrypters.Add('*', "2A");
            _encrypters.Add('+', "2B");
            _encrypters.Add(',', "2C");
            _encrypters.Add('-', "2D");
            _encrypters.Add('.', "2E");
            _encrypters.Add('/', "2F");
            _encrypters.Add('0', "30");
            _encrypters.Add('1', "31");
            _encrypters.Add('2', "32");
            _encrypters.Add('3', "33");
            _encrypters.Add('4', "34");
            _encrypters.Add('5', "35");
            _encrypters.Add('6', "36");
            _encrypters.Add('7', "37");
            _encrypters.Add('8', "38");
            _encrypters.Add('9', "39");
            _encrypters.Add(':', "3A");
            _encrypters.Add(';', "3B");
            _encrypters.Add('<', "3C");
            _encrypters.Add('=', "3D");
            _encrypters.Add('>', "3E");
            _encrypters.Add('?', "3F");
            _encrypters.Add('@', "40");
            _encrypters.Add('A', "41");
            _encrypters.Add('B', "42");
            _encrypters.Add('C', "43");
            _encrypters.Add('D', "44");
            _encrypters.Add('E', "45");
            _encrypters.Add('F', "46");
            _encrypters.Add('G', "47");
            _encrypters.Add('H', "48");
            _encrypters.Add('I', "49");
            _encrypters.Add('J', "4A");
            _encrypters.Add('K', "4B");
            _encrypters.Add('L', "4C");
            _encrypters.Add('M', "4D");
            _encrypters.Add('N', "4E");
            _encrypters.Add('O', "4F");
            _encrypters.Add('P', "50");
            _encrypters.Add('Q', "51");
            _encrypters.Add('R', "52");
            _encrypters.Add('S', "53");
            _encrypters.Add('T', "54");
            _encrypters.Add('U', "55");
            _encrypters.Add('V', "56");
            _encrypters.Add('W', "57");
            _encrypters.Add('X', "58");
            _encrypters.Add('Y', "59");
            _encrypters.Add('Z', "5A");
            _encrypters.Add('[', "5B");
            _encrypters.Add('\\', "5C");
            _encrypters.Add(']', "5D");
            _encrypters.Add('^', "5E");
            _encrypters.Add('_', "5F");
            _encrypters.Add('`', "60");
            _encrypters.Add('a', "61");
            _encrypters.Add('b', "62");
            _encrypters.Add('c', "63");
            _encrypters.Add('d', "64");
            _encrypters.Add('e', "65");
            _encrypters.Add('f', "66");
            _encrypters.Add('g', "67");
            _encrypters.Add('h', "68");
            _encrypters.Add('i', "69");
            _encrypters.Add('j', "6A");
            _encrypters.Add('k', "6B");
            _encrypters.Add('l', "6C");
            _encrypters.Add('m', "6D");
            _encrypters.Add('n', "6E");
            _encrypters.Add('o', "6F");
            _encrypters.Add('p', "70");
            _encrypters.Add('q', "71");
            _encrypters.Add('r', "72");
            _encrypters.Add('s', "73");
            _encrypters.Add('t', "74");
            _encrypters.Add('u', "75");
            _encrypters.Add('v', "76");
            _encrypters.Add('w', "77");
            _encrypters.Add('x', "78");
            _encrypters.Add('y', "79");
            _encrypters.Add('z', "7A");
            _encrypters.Add('{', "7B");
            _encrypters.Add('|', "7C");
            _encrypters.Add('}', "7D");
            _encrypters.Add('~', "7E");
           
        }

        public string GetValue(char input)
        {
            if (_encrypters.ContainsKey(input))
            {
                return _encrypters[input];
            }
            else
            {
                throw new InvalidOperationException("ASCII-Char not supported");
            }
            
        }
        public char GetKey(string input)
        {
            if (_encrypters.ContainsValue(input))
            {
                var item = _encrypters.FirstOrDefault(i => i.Value == input);
                return item.Key;
            }
            else
            {
                throw new InvalidOperationException("ASCII-Char not supported");
            }
        }
    }
}
