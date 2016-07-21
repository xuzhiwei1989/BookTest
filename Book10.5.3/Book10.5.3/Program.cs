using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book10._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入用户名：");
            string userName = Console.ReadLine();
            Console.Write("请输入密码：");
            string passWord = Console.ReadLine();
            Account account = new Account(userName, passWord);

            Console.WriteLine("用户名：" + account.UserName);
            Console.WriteLine("密码：" + account.PassWord);
        }

        public sealed class Account
        {
            private readonly string _userName;
            private readonly string _passWord;

            public string UserName
            {
                get { return _userName; }
            }

            public string PassWord
            {
                get { return _passWord; }
            }

            public Account(string userName, string passWord)
            {
                _userName = userName;
                _passWord = passWord;
            }
        }
    }
}
