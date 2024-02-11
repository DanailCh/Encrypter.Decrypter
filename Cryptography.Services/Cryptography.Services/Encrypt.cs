using Cryptography.Services.EncryptersDictionaries;
using System.Text;

namespace Cryptography.Services
{
    public  class Encrypt
    {
        
        private AsciiEncrypter _asciiEncrypter=new AsciiEncrypter();
        private ReverseEncrypter _reverseEncrypter=new ReverseEncrypter();
        private KeyConverter _keyConverter=new KeyConverter();
        private CharPositioner _charPositioner=new CharPositioner();

                
        public string EncryptMessage(string message, string key)
        {            
            string firstEncryption = ConvertToASCII(message);
            string secondEncryption = ApplyKey(firstEncryption,key);
            string thirdEncryption = ReverseSwap(secondEncryption);
            return thirdEncryption;
        }

        private string ApplyKey(string asciiString,string key)
        {
            string convertedKey=String.Empty;
            try
            {
                convertedKey = _keyConverter.ConvertKey(key);
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
            
            string modifiedKey = ModifyKey(convertedKey,asciiString);
            var stringWithAppliedKey = String.Empty;
            for (int i = 0; i < asciiString.Length; i++)
            {
                char currAsciiChar=asciiString[i];
                int currKeyChar = int.Parse(modifiedKey[i].ToString());
                if (Char.IsDigit(currAsciiChar))
                {
                    int combinationChar = (int.Parse(currAsciiChar.ToString())) + currKeyChar;
                    if (combinationChar>9)
                    {
                        combinationChar -=10;
                    }
                    stringWithAppliedKey+=combinationChar.ToString();
                }
                else
                {
                    int position;
                    try
                    {
                         position = _charPositioner.GetPosition(currAsciiChar);
                    }
                    catch (InvalidOperationException ex)
                    {

                        return ex.Message;
                    }                    

                    int combination = position + currKeyChar;
                    if (combination>26)
                    {
                        combination -= 26;
                    }
                    char combinationChar;
                    try
                    {
                        combinationChar = _charPositioner.GetChar(combination);
                    }
                    catch (InvalidOperationException ex)
                    {

                        return ex.Message;
                    }
                    stringWithAppliedKey += combinationChar.ToString();
                }
            }
            return stringWithAppliedKey;


        }
        
        private string ConvertToASCII(string message)
        {
            var sb = new StringBuilder();
           foreach (char c in message.ToCharArray())
            {
                try
                {
                    sb.Append(_asciiEncrypter.GetValue(c));
                }
                catch (InvalidOperationException ex)
                {

                    return ex.Message;
                }
                
            }
            return sb.ToString();
        }

        private string ReverseSwap(string input)
        {
            var sb=new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    char currChar = input[i];
                    char currCharReversed = _reverseEncrypter.GetValue(currChar);
                    sb.Append(currCharReversed);
                }
                catch (InvalidOperationException ex)
                {

                    return ex.Message;
                }
               
            }
            return sb.ToString();
        }

        private string ModifyKey(string convertedKey, string asciiString)
        {

            if (convertedKey.Length >= asciiString.Length)
            {
                return convertedKey;
            }
            else
            {
                while (convertedKey.Length < asciiString.Length)
                {
                    convertedKey += convertedKey;
                }
                return convertedKey;
            }
        }
    }
}