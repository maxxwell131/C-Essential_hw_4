using System;

namespace CEssential_hw_4
{
	/*
     *Задание
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Требуется: Изменить 12 пример первого урока (работа с документом) и 
        создать общий абстрактный класс для всех частей документа.
     */

	class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Title title = new Title();
            title.Content = "It is Title";

            Body body = new Body();
            body.Content = "It is BODY";

            Footer footer = new Footer();
            footer.Content = "It is CONTENT";

            title.Show();
            body.Show();
            footer.Show();
        }
    }
}
