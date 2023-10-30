using Tort;
using System.IO;
string formas = "";
int formai = 0;    
string razmers = "";
int razmeri = 0;
string vkyss = "";
int vkysi = 0;
string kolichs = "";
int kolichi = 1;
string glazyrs= "";
int glazyri = 0;
string dekors = "";
int dekori = 0;
string summs;
int summi;
do
{
    Console.Clear();
    Console.WriteLine("Сделайте тортик на свой вкус САМИ");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("  1.Форма");
    Console.WriteLine("  2.Размер");
    Console.WriteLine("  3.Вкус");
    Console.WriteLine("  4.Количество");
    Console.WriteLine("  5.Глазурь");
    Console.WriteLine("  6.Декор");
    Console.WriteLine("  7.Закончить заказ");
    summi = 0;
    summi = (formai + razmeri + vkysi + glazyri + dekori) * kolichi;
    Console.WriteLine("Цена: " + summi);
    summs = "Заказ:\n" + formas + razmers + vkyss + kolichs + glazyrs + dekors;
    Console.WriteLine(summs);
    Console.WriteLine("");
    int pos = MeNu.show(2, 8);
    switch (pos)
    {
        case 2:
            Console.Clear();
            Console.WriteLine("------Форма торта------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  1.Круг - 500");
            Console.WriteLine("  2.Квадрат - 600");
            Console.WriteLine("  3.Треугольник - 300");
            Console.WriteLine("");
            int pos1 = MeNu.show(2, 4);
            switch (pos1)
            {
                case 2:
                    formai = 500;
                    formas = "Форма: Круг - 500;\n ";
                    break;
                case 3:
                    formai = 600;
                    formas = "Форма: Квадрат - 600;\n ";
                    break;
                case 4:
                    formai = 300;
                    formas = "Форма: Треугольник - 300;\n ";
                    break;
            }
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("---Размер торта---");
            Console.WriteLine("------------------");
            Console.WriteLine("  1.Маленький - 400");
            Console.WriteLine("  2.Средний - 600");
            Console.WriteLine("  3.Большой - 800");
            Console.WriteLine("");
            int pos2 = MeNu.show(2, 4);
            switch (pos2)
            {
                case 2:
                    razmeri = 400;
                    razmers = "Размер: Маленький - 400;\n ";
                    break;
                case 3:
                    razmeri = 600;
                    razmers = "Размер: Средний - 600;\n ";
                    break;
                case 4:
                    razmeri = 800;
                    razmers = "Размер: Большой - 800;\n ";
                    break;
            }
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("---Вкус торта---");
            Console.WriteLine("----------------");
            Console.WriteLine("  1.Ананас - 200");
            Console.WriteLine("  2.Клубника - 300");
            Console.WriteLine("  3.Вишня - 150");
            Console.WriteLine("");
            int pos3 = MeNu.show(2, 4);
            switch (pos3)
            {
                case 2:
                    vkysi = 200;
                    vkyss = "Вкус: Ананас - 200;\n ";
                    break;
                case 3:
                    vkysi = 300;
                    vkyss = "Вкус: Клубника - 300;\n ";
                    break;
                case 4:
                    vkysi = 150;
                    vkyss = "Вкус: Вишня - 150;\n ";
                    break;
            }
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("---Количество тортов---");
            Console.WriteLine("----------------------");
            Console.WriteLine("  1.Один");
            Console.WriteLine("  2.Два");
            Console.WriteLine("  3.Три");
            Console.WriteLine("");
            int pos4 = MeNu.show(2, 4);
            switch (pos4)
            {
                case 2:
                    kolichi = 1;
                    kolichs = "Количество: Один;\n ";
                    break;
                case 3:
                    kolichi = 2;
                    kolichs = "Количество: Два;\n ";
                    break;
                case 4:
                    kolichi = 3;
                    kolichs = "Количество: Три;\n ";
                    break;
            }
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("---Глазурь торта---");
            Console.WriteLine("-------------------");
            Console.WriteLine("  1.Шоколад - 100; ");
            Console.WriteLine("  2.Бизе - 50; ");
            Console.WriteLine("  3.Ягодки - 200; ");
            Console.WriteLine("");
            int pos5 = MeNu.show(2, 4);
            switch (pos5)
            {
                case 2:
                    glazyri = 100;
                    glazyrs = "Глазурь: Шоколад - 100;\n ";
                    break;
                case 3:
                    glazyri = 50;
                    glazyrs = "Глазурь: Бизе - 50;\n ";
                    break;
                case 4:
                    glazyri = 200;
                    glazyrs = "Глазурь: Ягодки - 200;\n ";
                    break;
            }
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("---Декор торта---");
            Console.WriteLine("-----------------");
            Console.WriteLine("  1.Белый шоколад - 400");
            Console.WriteLine("  2.Чёрный шоколад - 200");
            Console.WriteLine("  3.Крем - 350");
            Console.WriteLine("");
            int pos6 = MeNu.show(2, 4);
            switch (pos6)
            {
                case 2:
                    dekori = 400;
                    dekors = "Декор: Белый шоколад - 400;\n ";
                    break;
                case 3:
                    dekori = 200;
                    dekors = "Декор: Чёрный шоколад - 200;\n ";
                    break;
                case 4:
                    dekori = 350;
                    dekors = "Декор: Крем - 350;\n ";
                    break;
            }
            break;
        case 8:               
            break;
    }
    if (pos == 0)
    {
        Console.Clear();
        Console.WriteLine("До новых встреч");
        break;
    }
} while (true);

