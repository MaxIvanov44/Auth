
using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Logic
{
    public class Pass_Check
    {
        public static string Check(string password)
        {
            Regex regex = new Regex(@"(?=^.{8,15}$)(?=.*\d)(?=.*[#?!@$%^&*-])(?=.*[A-Z])(?=.*[a-z])(?!.*\s).*$");
            if (password.Length >= 8)
            {
                if (regex.IsMatch(password))
                    return password;
                else throw new Exception("Выполнены не все требования к паролю!");
            }
            else throw new Exception("Пароль меньше 8 сиволов!");
        }
    }
}
