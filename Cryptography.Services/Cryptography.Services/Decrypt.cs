using Cryptography.Services.EncryptersDictionaries;
using System.Text;

namespace Cryptography.Services
{
    public class Decrypt
    {
        private AsciiEncrypter _asciiEncrypter = new AsciiEncrypter();
        private ReverseEncrypter _reverseEncrypter = new ReverseEncrypter();
        private KeyConverter _keyConverter = new KeyConverter();
        private CharPositioner _charPositioner = new CharPositioner();

        public string DecryptMessage(string message,string key)
        {           
            string firstDecryption =ReverseSwap(message);
            string secondDecryption = ApplyKey(firstDecryption,key);
            string thirdDecryption = ConvertFromASCII(secondDecryption);
            return thirdDecryption;
        }

        private string ReverseSwap(string input)
        {
            var sb = new StringBuilder();
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

        private string ApplyKey(string swapedString,string key)
        {
            string convertedKey = String.Empty;
            try
            {
                convertedKey = _keyConverter.ConvertKey(key);
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
            string modifiedKey = ModifyKey(convertedKey, swapedString);
            var stringWithAppliedKey = String.Empty;
            for (int i = 0; i < swapedString.Length; i++)
            {
                char currChar = swapedString[i];
                int currKeyChar = int.Parse(modifiedKey[i].ToString());
                if (Char.IsDigit(currChar))
                {
                    int combinationChar = (int.Parse(currChar.ToString())) - currKeyChar;
                    if (combinationChar <0)
                    {
                        combinationChar += 10;
                    }
                    stringWithAppliedKey += combinationChar.ToString();
                }
                else
                {
                    int position;
                    try
                    {
                        position = _charPositioner.GetPosition(currChar);
                    }
                    catch (InvalidOperationException ex)
                    {

                        return ex.Message;
                    }
                    int combination = position - currKeyChar;
                    if (combination <=0)
                    {
                        combination += 26;
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

        private string ConvertFromASCII(string asciiMessage)
        {
            var sb = new StringBuilder();
            string asciiPairs = String.Empty;
            for (int i = 0; i < asciiMessage.Length; i++)
            {
                char c = asciiMessage[i];
                if (i%2==0)
                {
                    asciiPairs+=c.ToString();
                }
                else
                {
                    try
                    {
                        asciiPairs += c.ToString();
                        sb.Append(_asciiEncrypter.GetKey(asciiPairs));
                        asciiPairs = String.Empty;
                    }
                    catch (InvalidOperationException)
                    {

                        return sb.ToString();
                        
                    }
                    
                }
            }
            return sb.ToString();
        }

        private string ModifyKey(string convertedKey, string swapedString)
        {

            if (convertedKey.Length >= swapedString.Length)
            {
                return convertedKey;
            }
            else
            {
                while (convertedKey.Length < swapedString.Length)
                {
                    convertedKey += convertedKey;
                }
                return convertedKey;
            }
        }

    }
}
