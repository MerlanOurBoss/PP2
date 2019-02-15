using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Layer // класс layer айналымдармен (int,FileSystemInfo[])
    {
        public FileSystemInfo[] Content
        {
            get;//осы операция арқылы айнымалыларды оқи аламыз
            set;//осы операция арқылы айнымалыларға мән бере аламыз
        }
        int selectedIndex;

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                if (value < 0)
                {
                    selectedIndex = Content.Length - 1;
                }
                else if (value >= Content.Length)
                {
                    selectedIndex = 0;
                }
                else
                {
                    selectedIndex = value;
                }
            }
        }

        public void Draw() // түс функциясы
        {
            Console.BackgroundColor = ConsoleColor.Black; // артынан түсі қара
            Console.Clear(); //  жаңарту
            for (int i = 0; i < Content.Length; i++) // шегінен шығуға болмайды
            {
                if (i == selectedIndex) // Жүгіргі массив индексіне тең болса, жұмыс істейтін шарт
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (Content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine((i + 1) + ". " + Content[i].Name);
            }
        }
    }
    enum FarMode
    {
        DirectoryView, FileView
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(@"C:\Users\Merlan\Desktop\LABS");  // Класс жасау әдістерін жасау, 
            // аударымдар мен тізімдерге каталогтар мен қосалқы каталогтарда.
            Stack<Layer> history = new Stack<Layer>();
            FarMode farMode = FarMode.DirectoryView;
            history.Push( // барлық мазмұнды dirinfo-дан басу;
                new Layer
                {
                    Content = root.GetFileSystemInfos(),
                    SelectedIndex = 0
                });
            while (true) //Цикл жұмысы шындыққа дейін жұмыс істейді
            {
                if (farMode == FarMode.DirectoryView)
                {
                    history.Peek().Draw(); //  бірінші бетті бояйды
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();  // кілтті оқу
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedIndex++;
                        break;
                    case ConsoleKey.Enter:
                        int x = history.Peek().SelectedIndex;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo d = fileSystemInfo as DirectoryInfo;
                            history.Push(new Layer { Content = d.GetFileSystemInfos(), SelectedIndex = 0 }); // егер папка болса  жинаққа қосылады
                        }
                        else
                        {
                            farMode = FarMode.FileView;
                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs)) // егер файл болса окимыз
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (farMode == FarMode.DirectoryView)
                        {
                            history.Pop();  // егер сіз BACKSPACE түймесін бассаныз, ол  жойыптыстайды
                        }
                        else if (farMode == FarMode.FileView)
                        {
                            farMode = FarMode.DirectoryView;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.F2: // папканы немесе файлды өзгерту үшін
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        string name = Console.ReadLine();
                        int x2 = history.Peek().SelectedIndex;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))  // егер таңдалған элемент dir болса
                        {
                            DirectoryInfo d2 = fileSystemInfo2 as DirectoryInfo;
                            Directory.Move(fileSystemInfo2.FullName, d2.Parent.FullName + "/" + name);
                            history.Peek().Content = d2.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fs2 = fileSystemInfo2 as FileInfo; //  егер таңдалған элемент file болса
                            File.Move(fileSystemInfo2.FullName, fs2.Directory.FullName + "/" + name);
                            history.Peek().Content = fs2.Directory.GetFileSystemInfos();
                        }
                        break;
                    case ConsoleKey.Delete: // файлды немесе  папканы өшіру
                        int x3 = history.Peek().SelectedIndex;
                        FileSystemInfo fileSystemInfo3 = history.Peek().Content[x3];
                        if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo d3 = fileSystemInfo3 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo3.FullName, true);
                            history.Peek().Content = d3.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fs3 = fileSystemInfo3 as FileInfo;
                            File.Delete(fileSystemInfo3.FullName);
                            history.Peek().Content = fs3.Directory.GetFileSystemInfos();
                        }
                        history.Peek().SelectedIndex--;
                        break;
                }
            }
        }
    }
}