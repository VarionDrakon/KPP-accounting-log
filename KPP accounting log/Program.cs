using System.Diagnostics;

namespace KPP_accounting_log
{
    public class DateTimeStorage
    {
        public string? nowEnter;
        public void UpdateDateTimeAuthorization()
        {
            nowEnter = DateTime.Now.ToString("ddMMyyyyHHmmss") + "note.log";
        }
    }
    public abstract class LoginTemplate : DateTimeStorage
    {
        public string? FullName;
        public string? Purpose;
    }
    internal class Program : LoginTemplate
    {
        public string? NameProfileAuthorization { private get; set; }
        readonly string[] arrLogPassArray = File.ReadAllLines(@"Users/token.txt");
        static void Main(string[] args)
        {
            Console.WriteLine("Starting app...");

            var anInstanceProgramClass = new Program();
            anInstanceProgramClass.MainConsoleWindow();
        }
        private void MainConsoleWindow()
        {
            Console.Clear();
            WorkplaceAuthorization();
        }
        private void WorkplaceAuthorization()
        {
            if (Directory.Exists(@"Users/") == false || File.Exists(@"Users/token.txt") == false)
            {
                Console.WriteLine("Вы не можете начать работу так как отсутствует директория или учётный лист пользователей, обратитесь к системному администратору для решения проблемы!");
            }
            else
            {
                Console.WriteLine("Для начала работы, пожалуйста, авторизируйтесь. Введите логин, затем нажмите enter и введите пароль, после чего повторно нажмите enter!");
                string? employeeName = Console.ReadLine();
                NameProfileAuthorization = employeeName;
                Console.WriteLine("Теперь введите пароль!");
                try
                {
                    int? employeePass = Convert.ToInt32(Console.ReadLine());

                    bool allowCorrectLog = arrLogPassArray.Contains(employeeName);
                    bool allowCorrectPass = arrLogPassArray.Contains(employeePass.ToString());

                    if (allowCorrectLog == true)
                    {
                        if (allowCorrectPass == true)
                        {
                            UpdateDateTimeAuthorization();
                            EnteringCredentials();
                        }
                        else
                        {
                            Console.WriteLine("Неправильный пароль! Повторите попытку.");
                            WorkplaceAuthorization();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильный логин! Повторите попытку.");
                        WorkplaceAuthorization();
                    }
                }
                catch
                {
                    Console.WriteLine("ОШИБКА! Пароль вводится только цифрами! Повторите попытку.");
                    WorkplaceAuthorization();
                }
            }
        }
        private void EnteringCredentials()
        {
            Console.Clear();
            Console.WriteLine("Что Вы хотите сделать? \n 1. Записать вход \n 2. Записать выход \n 3. Войти в другую учётную запись \n 4. Выйти из программы");
            string? number = Console.ReadLine();

            if (Directory.Exists(@"Log/") == false)
            {
                Directory.CreateDirectory("Log");
            }
            if (number == "1")
            {
                Console.WriteLine("ВВедите ФИО:");
                FullName = Console.ReadLine();
                Console.WriteLine("ВВедите цель входа:");
                Purpose = Console.ReadLine();
                using (StreamWriter writeLog = new StreamWriter(@"Log/" + NameProfileAuthorization + nowEnter, true))
                {
                    writeLog.WriteLine("ФИО: " + FullName + " Время: " + DateTime.Now + " Цель входа: " + Purpose);
                }
                EnteringCredentials();
            }
            else if (number == "2")
            {
                Console.WriteLine("ВВедите ФИО:");
                FullName = Console.ReadLine();
                using (StreamWriter writeLog = new StreamWriter(@"Log/" + NameProfileAuthorization + nowEnter, true))
                {
                    writeLog.WriteLine("ФИО: " + FullName + " Время: " + DateTime.Now);
                }
                EnteringCredentials();
            }
            else if (number == "3")
            {
                MainConsoleWindow();
            }
            else if (number == "4")
            {
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Console.WriteLine("Invalid number! Retry attempt");
                EnteringCredentials();
            }
        }
    }
}