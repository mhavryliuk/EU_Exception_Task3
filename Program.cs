using System;
using System.IO;

/**<remark>
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 * 
 * Напишите программу, которая вводит имя файла вместе с полным адресом к файлу (например, C: \ WINDOWS \ win.ini),
 * считывает его содержимое и печатает его на консоли. Найти в MSDN, как использовать System.IO.File.ReadAllText (...).
 * Обязательно воспользуйтесь всеми исключениями и напечатайте понятные сообщения об ошибках.
 * https://msdn.microsoft.com/ru-ru/library/system.exception(v=vs.110).aspx
 * </remark>*/

namespace _20180306_Task3_Exception
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter filename and path to him (e.g. C:\\WINDOWS\\win.ini)");
            string file = Console.ReadLine();

            try
            {
                if (file != null) Console.WriteLine(File.ReadAllText(file));
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("A drive is unavailable or does not exist.");
                Console.WriteLine("Привод недоступен или не существует.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Part of a directory path is not valid.");
                Console.WriteLine("Недопустимая часть пути к каталогу.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("A file does not exist.");
                Console.WriteLine("Файл не существует.");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("A path or file name exceeds the maximum system-defined length.");
                Console.WriteLine("Путь или имя файла превышает максимальную системную длину.");
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("The operation is not supported on the current platform.");
                Console.WriteLine("Операция не поддерживается на текущей платформе.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}