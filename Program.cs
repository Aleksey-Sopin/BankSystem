using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] usermenu = new string[5];
            string[] adminmenu = new string[5];
            adminmenu[0] = "See user list";
            adminmenu[1] = "Add user";
            adminmenu[2] = "Delete user";
            adminmenu[3] = "Change username";
            adminmenu[4] = "Exit to login";

            var arrayLenght = 0;
            var valueArray = new string[arrayLenght];
            bool isMenu = true;
            var menuPosition = 0;
            while (isMenu)
            {
                for (var i = 0; i < adminmenu.Length; i++)
                {
                    if (i == menuPosition)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(adminmenu[i]);
                        Console.ResetColor();
                        continue;
                    }
                    Console.WriteLine(adminmenu[i]);
                }
                ConsoleKey consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.DownArrow)
                {
                    menuPosition++;
                }
                if (menuPosition == adminmenu.Length)
                {
                    menuPosition = 0;
                }
                if (consoleKey == ConsoleKey.UpArrow)
                {
                    menuPosition--;
                }
                Console.Clear();
                if (menuPosition == -1)
                {
                    menuPosition = 4;
                }
                if (consoleKey == ConsoleKey.Enter && menuPosition == 0)
                {
                    for (var i = 0; i < valueArray.Length; i++)
                    {
                        Console.WriteLine(valueArray[i]);
                    }
                }
                if (consoleKey == ConsoleKey.Enter && menuPosition == 1)
                {
                    arrayLenght++;
                    var arr = new string[arrayLenght];
                    for (var i = 0; i < valueArray.Length; i++)
                    {
                        arr[i] = valueArray[i];
                    }
                    Console.Write("Enter new element: ");
                    arr[arr.Length - 1] = Console.ReadLine();
                    valueArray = arr;
                    Console.Clear();
                }
                if (consoleKey == ConsoleKey.Enter && menuPosition == 2)
                {
                    arrayLenght--;
                    var arr = new string[arrayLenght];

                    for (var i = 0; i < arr.Length; i++)
                    {
                        arr[i] = valueArray[i];
                    }
                    valueArray = arr;
                }
                if (consoleKey == ConsoleKey.Enter && menuPosition == 4)
                {
                    break;
                }
                /**/
                if (consoleKey == ConsoleKey.Enter && menuPosition == 3)
                {                 
                    while (true)
                    {                  
                        var usercount = 0;
                        //Массивы не изменяют свой размер автоматически вот тут valueArray.Lenght всегда будет 0 смотри внимательно на то как ты инициализируешь его
                        for (var i = 0; i < valueArray.Length; i++)
                        {
                            if (i == usercount)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(valueArray[i]);
                                Console.ResetColor();
                                continue;
                            }
                            Console.WriteLine(valueArray[i]);
                        }
                        ConsoleKey consoleKeyuser = Console.ReadKey().Key;
                        if (consoleKeyuser == ConsoleKey.DownArrow)
                        {
                            usercount++;
                        }
                        if (usercount == valueArray.Length)
                        {
                            usercount = 0;
                        }
                        if (consoleKeyuser == ConsoleKey.UpArrow)
                        {
                            usercount--;
                        }
                        Console.Clear();
                        if (usercount == -1)
                        {
                            usercount = valueArray.Length;
                        }

                        if (consoleKeyuser == ConsoleKey.Escape)
                        {
                            break;
                        }
                        
                    }

                }

            }
        }
    }
}

/*var menuArr = new string[3];
menuArr[0] = "Add new element";
menuArr[1] = "Delete last element";
menuArr[2] = "Exit";*//*

var arrayLenght = 2;
var valueArray = new string[arrayLenght];
valueArray[0] = "a";
valueArray[1] = "b";

bool isMenu = true;
var menuPosition = default(int);

while (isMenu)
{
    for (var i = 0; i < menuArr.Length; i++)
    {
        if (i == menuPosition)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(menuArr[i]);
            Console.ResetColor();
            continue;
        }
        Console.WriteLine(menuArr[i]);
    }

    ConsoleKey consoleKey = Console.ReadKey().Key;
    if (consoleKey == ConsoleKey.DownArrow)
    {
        menuPosition++;
    }
    if (consoleKey == ConsoleKey.UpArrow)
    {
        menuPosition--;
    }
    Console.Clear();
    if (consoleKey == ConsoleKey.Enter && menuPosition == 2)
    {
        break;
    }
    if (consoleKey == ConsoleKey.Enter && menuPosition == 1)
    {
        arrayLenght--;
        var arr = new string[arrayLenght];

        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = valueArray[i];
        }
        valueArray = arr;
    }
    if (consoleKey == ConsoleKey.Enter && menuPosition == 0)
    {
        arrayLenght++;
        var arr = new string[arrayLenght];
        for (var i = 0; i < valueArray.Length; i++)
        {
            arr[i] = valueArray[i];
        }
        Console.Write("Enter new element: ");
        arr[arr.Length - 1] = Console.ReadLine();
        valueArray = arr;
    }

    for (var i = 0; i < valueArray.Length; i++)
    {
        Console.WriteLine(valueArray[i]);
    }
}*/

/*Программа типа Банковская система
Логинка и два типа пользователей Администратор и Пользователь

Админ умеет 
1 смотреть список пользователей
2 добавлять пользователя
3 удалять пользователя
4 изменять имя пользователя 

Пользователь 
1 Имеет счет с кеоличеством денег
2 Может смотреть деньги на счете
3 Класть деньги на счет 
4 снимать деньги со счета*/
