public static bool IsKaprekarNumber(long number)
        {
            long squre = number * number;

            string sSqure = squre.ToString();

            string last = sSqure.Substring(sSqure.Length - number.ToString().Length);

            string first = sSqure.Substring(0, sSqure.Length - last.Length);

            int number1 = string.IsNullOrEmpty(first) ? 0 : Convert.ToInt32(first);
            int number2 = string.IsNullOrEmpty(last) ? 0 : Convert.ToInt32(last);

            if (number1 + number2 == number)
            {
                return true;
            }

            return false;
        }
