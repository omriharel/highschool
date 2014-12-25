using System;
using System.Collections.Generic;
using System.Text;

namespace InputValidation
{
    public class InputValidation
    {
        private InputValidation() { }

        public static bool IsInt(string input)
        {
            int value;
            bool ok = true;
            try
            {
                value = int.Parse(input);
            }
            catch (FormatException) { ok = false; }
            catch (OverflowException) { ok = false; }
            if (ok)
                return true;
            else
                return false;
        }

        public static bool IsDouble(string input)
        {
            double value = Double.NaN;
            try
            {
                value = double.Parse(input);
            }
            catch (FormatException) { }
            catch (OverflowException) { }
            if (value == Double.NaN)
                return false;
            else
                return true;
        }
    }
}
