namespace _1_lab
{
    /// <summary>
    /// Меню
    /// </summary>
    public static class Menu
    {
        
        private const string titleMessage = "\tМеню:\n1) read - чтение из файла;\n2) write - запись в файл\n3)crypto - шифрация/дешифрация файла\n4)fileinfo - информация о файле\n5)Palindrom";
        private const string Message = "\tВведите путь к файлу:";
         private const string caseMessage = "a - записать в конец файла;\nn - перезаписать файл";
         private const string errMessage = "Выберете из списка!";
         /// <summary>
         /// Вывод всего меню
         /// </summary>
        public static void Title()
        {
            System.Console.WriteLine(titleMessage);
            int t = System.Convert.ToInt32(System.Console.ReadLine());
            Execute(t);
        }
        private static void Execute(int command)
        {
            string temp;
            switch(command)
            {
                case 1:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                System.Console.WriteLine(Reader.Read(temp));
                break;
                case 2:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                System.Console.WriteLine("Введите строку:");
                string data =System.Console.ReadLine();
                System.Console.WriteLine(caseMessage);
                string method =System.Console.ReadLine();
                Reader.Write(temp,data,method);
                break;
                case 3:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                System.Console.WriteLine("Введите пароль для шифрации/дешифрации:");
                data =System.Console.ReadLine();
                System.Console.WriteLine("e - шифрация, d - дешифрация");
                method =System.Console.ReadLine();
                Crypto.Encode(temp,data,method);
                break;
                case 4:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                foreach(var t in Reader.GetFileInfo(temp))
                {
                   System. Console.WriteLine(t);
                }
                break;
                case 5:
                System.Console.WriteLine(Message);
                temp =System.Console.ReadLine();
                System.Console.WriteLine(Reader.Palindrom(temp));
                break;
            }
            Title();
        }
    }
}