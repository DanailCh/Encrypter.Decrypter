using Cryptography.Services;
using System.Linq.Expressions;

namespace Encrypter.Decrypter
{
    public partial class Form1 : Form
    {
        private Encrypt _encrypt = new Encrypt();
        private Decrypt _decrypt = new Decrypt();
        private int keyBellowFourErrorCount;
        private int keyAboveThirtyErrorCount;
        private Dictionary<string, int> inputErrorCount=new Dictionary<string, int>();
        private bool reachedAnoyingMessage = false;
        public Form1()
        {
            InitializeComponent();
            inputErrorCount.Add("inputEncryptErrorCount", 0);
            inputErrorCount.Add("inputDecryptErrorCount", 0);
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (reachedAnoyingMessage)
            {
                FinalAnoyingMessage();
            }
            else 
            {
                string key = KeyBox.Text;
                string plainText = InputBox.Text;
                if (IsFilledIn(key, plainText, "inputEncryptErrorCount"))
                {
                    if (IsAlphaNumeric(key))
                    {
                        if (KeyInLength(key))
                        {
                            string encryptedText = _encrypt.EncryptMessage(plainText, key);
                            KeyBox.Text = String.Empty;
                            OutputBox.Text = encryptedText;
                            keyBellowFourErrorCount = 0;
                            keyAboveThirtyErrorCount = 0;
                            inputErrorCount["inputEncryptErrorCount"] = 0;
                            inputErrorCount["inputDecryptErrorCount"] = 0;
                        }
                    }
                }
            }
            
        }       
        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (reachedAnoyingMessage)
            {
                FinalAnoyingMessage();
            }
            else
            {
                string key = KeyBox.Text;
                string encryptedText = InputBox.Text;

                if (IsFilledIn(key, encryptedText, "inputDecryptErrorCount"))
                {
                    if (IsAlphaNumeric(key))
                    {
                        WittyRemark(key);
                        string decryptedText = _decrypt.DecryptMessage(encryptedText, key);
                        KeyBox.Text = String.Empty;
                        OutputBox.Text = decryptedText;
                        keyBellowFourErrorCount = 0;
                        keyAboveThirtyErrorCount = 0;
                        inputErrorCount["inputEncryptErrorCount"] = 0;
                        inputErrorCount["inputDecryptErrorCount"] = 0;
                    }
                }
            }          
              
        }

        private bool KeyInLength(string key)
        {
            if (key.Length<4)
            {
                switch (keyBellowFourErrorCount)
                {
                    case 0:
                        ErrorMessageForKey.Text = "Your Key is too short.MIN 4";
                        keyBellowFourErrorCount++;
                        return false;                        
                    case 1:
                        ErrorMessageForKey.Text = "Can't you count? I said minimum 4 characters long.";
                        keyBellowFourErrorCount++;
                        return false;                        
                    case 2:
                        ErrorMessageForKey.Text = "Let me say this in a more simple way. KEY SHORT, MAKE LONGER!";
                        keyBellowFourErrorCount++;
                        return false;
                    case 3:                        
                        ErrorMessageForKey.Text = "SERIOUSLY you're gonna use THAT as your Key? Put some effort into it.";
                        keyBellowFourErrorCount++;
                        return false;
                    case 4:                        
                        ErrorMessageForKey.Text = "OK I'll use your Key but don't blame me if someone guesses it.";                       
                        return true;
                   
                    
                }
            }
            else if (key.Length > 30)
            {
                switch (keyAboveThirtyErrorCount)
                {
                    case 0:
                        ErrorMessageForKey.Text = "Whoa there that's a pretty long Key.MAX 30";
                        keyAboveThirtyErrorCount++;
                        return false;
                    case 1:
                        ErrorMessageForKey.Text = "I SAID IT'S TOO LONG. MAX 30";
                        keyAboveThirtyErrorCount++;
                        return false;
                    case 2:
                        ErrorMessageForKey.Text = "Are you even gonna remember that?";
                        keyAboveThirtyErrorCount++;
                        return false;
                    case 3:
                        ErrorMessageForKey.Text = "At this point I think you are overcompensating for something.";
                        keyAboveThirtyErrorCount++;
                        return false;
                    case 4:
                        ErrorMessageForKey.Text = "You are so stubborn. I've used your Key. Good luck remembering it next time.";
                        return true;                   

                }
            }
            
            return true;
        }
        private bool IsFilledIn(string key,string plainText,string dictionaryKey)
        {
            bool isFilledIn = true;
            if (key == String.Empty)
            {
                ErrorMessageForKey.Text = "Aren't you forgetting something? Maybe THE KEY!";
                isFilledIn= false;
            }
            if(inputErrorCount[dictionaryKey] == 6)
            {
                OutputBox.Text = String.Empty;
                InputBox.Text = String.Empty;
                KeyBox.Text = String.Empty;
                string message = "It seems like you don't know how to use this program. Let me close it for you because at this point I'm not sure you can even do that.";
                string title = "I am revoking your privileges for using this program.";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    reachedAnoyingMessage = true;
                }
                isFilledIn = false;
            }
            if (plainText == "This is the Input. PUT YOUR TEXT HERE!" && inputErrorCount[dictionaryKey] == 5)
            {
                OutputBox.Text = "Did you just try to use MY Input message? Not cool man.";
                inputErrorCount[dictionaryKey]++;
                isFilledIn = false;                
            }

            if (plainText == String.Empty)
            {
                switch (inputErrorCount[dictionaryKey])
                {
                    case 0:
                        if (dictionaryKey== "inputDecryptErrorCount")
                        {
                            OutputBox.Text = "What are you trying to decrypt? THE AIR? FILL IN YOUR INPUT!";
                            inputErrorCount[dictionaryKey]++;
                            isFilledIn = false;
                        }
                        else
                        {
                            OutputBox.Text = "Your encrypted text would be here if you DIDN'T FORGET TO FILL IN THE INPUT!";
                            inputErrorCount[dictionaryKey]++;
                            isFilledIn = false;
                        }
                        break;
                    case 1:
                        OutputBox.Text = "FILL IN YOUR INPUT!";
                        inputErrorCount[dictionaryKey]++;
                        isFilledIn = false;
                        break;
                    case 2:
                        OutputBox.Text = "ARE YOU DENSE? YOUR INPUT IS EMPTY!";
                        inputErrorCount[dictionaryKey]++;
                        isFilledIn = false;
                        break;
                    case 3:
                        OutputBox.Text = "DO YOU EVEN KNOW WHERE THE INPUT IS?";
                        inputErrorCount[dictionaryKey]++;
                        isFilledIn = false;
                        break ;
                    case 4:
                        InputBox.Text = "This is the Input. PUT YOUR TEXT HERE!";
                        inputErrorCount[dictionaryKey]++;
                        OutputBox.Text =String.Empty;
                        isFilledIn = false;
                        break;
                   

                }
            }

            return isFilledIn;
        }
        private bool IsAlphaNumeric(string key)
        {
            
            for (int i = 0; i < key.Length; i++)
            {
                char currChar = key[i];
                if (!char.IsLetterOrDigit(currChar))
                {
                   
                   KeyBox.Text = String.Empty;
                   ErrorMessageForKey.Text = "Can't you read? Key must be ALPHANUMERIC!";
                    return false;                   
                }
            }
            return true;
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            if (reachedAnoyingMessage)
            {
                FinalAnoyingMessage();
            }
            string key=KeyBox.Text;
            if (key != String.Empty) {
                char lastAddedChar = key[key.Length-1];
                if (!Char.IsLetterOrDigit(lastAddedChar))
                {                    
                    ErrorMessageForKey.Text = "Key must be alphanumeric!";
                }
                else
                {
                    ErrorMessageForKey.Text = String.Empty;
                }
            }           
           
        }
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (reachedAnoyingMessage)
            {
                FinalAnoyingMessage();
            }
        }
        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            if (reachedAnoyingMessage)
            {
                FinalAnoyingMessage();
            }
        }

        private void WittyRemark(string key)
        {
            if (key.Length < 4)
            {
                ErrorMessageForKey.Text = "Ah yes the one with pathetically short Key.";
            }
            else if (key.Length > 30)
            {
                ErrorMessageForKey.Text = "Oh, you actualy remembered your Key.";
            }
            return;
        }
        private void FinalAnoyingMessage()
        {
            string message = "Due to the fact that you can't follow simple directions and your goal is to annoy me I am now closing this program. GOOD BYE!";
            string title = "I am sorry but you can't use this program anymore.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}