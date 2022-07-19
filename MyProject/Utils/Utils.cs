using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Utils
{
    public class Utils
    {
        public static string TestPassword(string password)
        {
            if (password.Length >= 5 && password.Length <= 10)
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isSpecSymbol = false;

                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    if ("@#$%^&*".Contains(item))
                    {
                        isSpecSymbol = true;
                    }
                }

                if (isDigit == false)
                {
                    return "Пароль должен содержать цифры!";
                }
                if (isUpper == false)
                {
                    return "Пароль должен содержать заглавные буквы!";
                }
                if (!isSpecSymbol)
                {
                    return "Пароль должен содержать спецсимволы!";
                }
                return "Ok";

            }
            else
            {
                return "Длина пароля должна быть от 5 до 10 символов!";
            }
        }

    }
}
