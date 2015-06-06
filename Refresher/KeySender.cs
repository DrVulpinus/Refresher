using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Refresher
{
    class KeySender
    {
        public KeySender()
        {

        }
        public void sendKeys(String keys)
        {
            System.Windows.Forms.SendKeys.Send(keys);
        }
        public void sendFKey(int number)
        {
            sendKeys(getFKeyString(number));
        }
        public String getFKeyString(int number)
        {
            if (number < 1 || number > 12)
            {
                throw new ArgumentOutOfRangeException("number", number, "The number for the 'F' keys must be between 1 and 12");
            }
            String key = "{F";
            key += number.ToString();
            key += "}";
            return key;
        }
        public String addShift(String keys)
        {
            String modKeys = "+(";
            modKeys += keys;
            modKeys += ")";
            return modKeys;
        }
        public String addCtrl(String keys)
        {
            String modKeys = "^(";
            modKeys += keys;
            modKeys += ")";
            return modKeys;
        }
        public String addAlt(String keys)
        {
            String modKeys = "%(";
            modKeys += keys;
            modKeys += ")";
            return modKeys;
        }
    }
}
