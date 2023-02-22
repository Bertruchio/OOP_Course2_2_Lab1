using System;
//Добавление и удаление из списка

namespace OOP_Course2_2_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                #region [ Case ]
                Console.WriteLine("\t\t\tВариант 24 (повышенный уровень)\n");
                Console.WriteLine("1. Ввести с клавиатуры текст. Выяснить, является ли данный текст палиндромом.\n");
                Console.WriteLine("2. В трёх произвольно заданных положительных матрицах размера 3x3 определить");
                Console.WriteLine("максимальные элементы. Считая найденные значения длинами отрезков, определить");
                Console.WriteLine("возможность построения из них треугольника.\n");
                Console.WriteLine("3. Создать список \"Правители России\" (Правитель, Год начала правления, Год)");
                Console.WriteLine("конца правления). Вывести на экран информацию о правителе, который правил в");
                Console.WriteLine("году, который ввёл пользователь.\n");
                Console.WriteLine("4. Выход\n\n");
                #endregion

                int taskNumber;
                Console.WriteLine("Введите номер задачи: ");
                while (!int.TryParse(Console.ReadLine(), out taskNumber))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число");
                }
                switch (taskNumber)
                {
                    case 1:
                        #region [ Palindrome ]
                        Console.Clear();

                        Console.WriteLine("Введите ваше слово (палиндром): ");
                        string text = Console.ReadLine();
                        IsPalindrome(text);

                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion
                    case 2:
                        #region [ Triangle ]
                        Console.Clear();
                        int[,] matrix1 = new int[3, 3];
                        int[,] matrix2 = new int[3, 3];
                        int[,] matrix3 = new int[3, 3];
                        Console.WriteLine("Заполнение первой матрицы");
                        matrix1 = FillMatrixFromRandom(matrix1, 0, 8);
                        Console.WriteLine("Заполнение второй матрицы");
                        matrix2 = FillMatrixFromRandom(matrix2, 0, 99);
                        Console.WriteLine("Заполнение третьей матрицы");
                        matrix3 = FillMatrixFromRandom(matrix3, 0, 99);

                        Triangle(matrix1, matrix2, matrix3);

                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion
                    case 3:
                        #region [ Russian Rulers ]
                        Console.Clear();
                        List<Ruler> russianRulers = new List<Ruler>()
                        {
                            new Ruler("Рюрик Новгородский", 862, 879),
                            new Ruler("Олег Вещий", 879, 912),
                            new Ruler("Игорь Старый", 912, 947),
                            new Ruler("Святослав I", 946, 972),
                            new Ruler("Ярополк Святославич", 972, 980),
                            new Ruler("Владимир I Святославич Красное Солнышко", 980, 1015),
                            new Ruler("Святополк I Ярополкович Окаянный", 1015, 1015),
                            new Ruler("Ярослав Владимирович Мудрый", 1015, 1017),
                            new Ruler("Святополк I Ярополкович Окаянный", 1017, 1019),
                            new Ruler("Ярослав Владимирович Мудрый", 1019, 1024),
                            new Ruler("Ярослав Владимирович Мудрый, Мстислав Владимирович", 1024, 1036),
                            new Ruler("Ярослав Владимирович Мудрый", 1036, 1054),
                            new Ruler("Изяслав Ярославич", 1054, 1068),
                            new Ruler("Всеслав Брячиславич Полоцкий", 1068, 1069),
                            new Ruler("Изяслав Ярославич", 1069, 1073),
                            new Ruler("Святослав II Ярославич", 1073, 1076),
                            new Ruler("Всеволод I Ярославич", 1076, 1076),
                            new Ruler("Изяслав Ярославич", 1077, 1078),
                            new Ruler("Всеволод I Ярославич", 1078, 1093),
                            new Ruler("Святополк II Изяславич", 1093, 1113),
                            new Ruler("Владимир II Всеволодович Мономах", 1113, 1125),
                            new Ruler("Мстислав Владимирович Великий", 1125, 1132),
                            new Ruler("Ярополк Владимирович", 1132, 1139),
                            new Ruler("Вячеслав Владимирович", 1139, 1139),
                            new Ruler("Всеволод II Ольгович", 1139, 1146),
                            new Ruler("Игорь Ольгович", 1146, 1146),
                            new Ruler("Изяслав Мстиславич", 1146, 1149),
                            new Ruler("Юрий Владимирович Долгорукий", 1149, 1150),
                            new Ruler("Вячеслав Владимирович", 1150, 1150),
                            new Ruler("Изяслав Мстиславич", 1150, 1150),
                            new Ruler("Юрий Владимирович Долгорукий", 1150, 1150),
                            new Ruler("Изяслав Мстиславич", 1151, 1154),
                            new Ruler("Ростислав Мстиславич", 1154, 1154),
                            new Ruler("Изяслав Давыдович", 1155, 1155),
                            new Ruler("Юрий Владимирович Долгорукий", 1155, 1157),
                            new Ruler("Изяслав Давыдович", 1157, 1159),
                            new Ruler("Ростислав Мстиславич", 1159, 1159),
                            new Ruler("Изяслав Давыдович", 1159, 1160),
                            new Ruler("Ростислав Мстиславич", 1160, 1168),
                            new Ruler("Мстислав Изяславич", 1168, 1169),

                            new Ruler("Андрей Юрьевич Суздальский", 1169, 1174),
                            new Ruler("Ярополк Ростиславич", 1174, 1174),
                            new Ruler("Михалко Юрьевич", 1174, 1176),
                            new Ruler("Всеволод III Юрьевич Большое Гнездо", 1176, 1212),
                            new Ruler("Юрий Всеволодович", 1212, 1216),
                            new Ruler("Константин Всеволодович Добрый", 1216, 1218),
                            new Ruler("Юрий Всеволодович", 1218, 1238),
                            new Ruler("Ярослав Всеволодович", 1238, 1246),
                            new Ruler("Святослав Всеволодович", 1246, 1248),
                            new Ruler("Михаил Ярославич Хоробрит", 1248, 1248),
                            new Ruler("Андрей Ярославич", 1248, 1252),
                            new Ruler("Александр Ярославич Невский", 1252, 1263),
                            new Ruler("Ярослав Ярославич", 1264, 1272),
                            new Ruler("Василий Ярославич", 1272, 1276),
                            new Ruler("Дмитрий Александрович", 1276, 1281),
                            new Ruler("Андрей Александрович", 1281, 1283),
                            new Ruler("Дмитрий Александрович", 1283, 1294),
                            new Ruler("Андрей Александрович", 1294, 1304),
                            new Ruler("Михаил Ярославич Тверской", 1304, 1318),
                            new Ruler("Юрий Даниилович", 1319, 1322),
                            new Ruler("Дмитрий Михайлович Грозные Очи", 1322, 1326),
                            new Ruler("Александр Михайлович Тверской", 1326, 1327),

                            new Ruler("Иван I Даниилович Калита", 1328, 1341),
                            new Ruler("Симеон Иванович Гордый", 1341, 1353),
                            new Ruler("Иван II Иванович Милостивый", 1353, 1359),
                            new Ruler("Дмитрий Константинович Суздальский", 1359, 1363),
                            new Ruler("Дмитрий Иванович Донской", 1363, 1389),
                            new Ruler("Василий I Дмитриевич", 1389, 1425),
                            new Ruler("Василий II Васильевич", 1425, 1433),
                            new Ruler("Юрий Дмитриевич Звенигородский", 1433, 1434),
                            new Ruler("Василий II Васильевич Темный", 1434, 1462),

                            new Ruler("Иван III Васильевич", 1462, 1505),
                            new Ruler("Василий III Иванович", 1505, 1533),
                            new Ruler("Иван IV Васильевич Грозный", 1533, 1584),
                            new Ruler("Федор Иванович", 1584, 1598),
                            new Ruler("Борис Федорович Годунов", 1598, 1605),
                            new Ruler("Федор Борисович Годунов", 1605, 1605),
                            new Ruler("Лжедмитрий I", 1605, 1606),
                            new Ruler("Василий IV Шуйский", 1606, 1610),
                            new Ruler("Семибоярщина", 1610, 1613),
                            new Ruler("Михаил Федорович Романов", 1613, 1645),
                            new Ruler("Алексей Михайлович Романов Тишайший", 1645, 1676),
                            new Ruler("Федор Алексеевич Романов", 1676, 1682),
                            new Ruler("Иван V Алексеевич Романов, Петр I", 1682, 1696),

                            new Ruler("Петр I Алексеевич", 1696, 1725),
                            new Ruler("Екатерина I Алексеевна", 1725, 1727),
                            new Ruler("Петр II Алексеевич", 1727, 1730),
                            new Ruler("Анна Ивановна", 1730, 1740),
                            new Ruler("Иван VI Антонович", 1740, 1741),
                            new Ruler("Елизавета Петровна", 1741, 1761),
                            new Ruler("Петр III Федорович", 1761, 1762),
                            new Ruler("Екатерина II Алексеевна", 1762, 1796),
                            new Ruler("Павел I Петрович", 1796, 1801),
                            new Ruler("Александр I Павлович", 1801, 1825),
                            new Ruler("Николай I Павлович", 1825, 1855),
                            new Ruler("Александр II Николаевич", 1855, 1881),
                            new Ruler("Александр III Александрович", 1881, 1894),
                            new Ruler("Николай II Александрович", 1894, 1917),

                            new Ruler("Львов Георгий Евгеньевич", 1917, 1917),
                            new Ruler("Керенский Александр Фёдорович", 1917, 1917),
                            new Ruler("Колчак Александр Васильевич", 1918, 1920),

                            new Ruler("Ленин Владимир Ильич", 1917, 1924),
                            new Ruler("Каменев Лев Борисович", 1917, 1917),
                            new Ruler("Свердлов Яков Михайлович", 1917, 1919),
                            new Ruler("Владимирский Михаил Фёдорович", 1919, 1919),
                            new Ruler("Калинин Михаил Иванович", 1919, 1946),
                            new Ruler("Шверник Николай Михайлович", 1946, 1953),
                            new Ruler("Ворошилов Климент Ефремович", 1953, 1960),
                            new Ruler("Брежнев Леонид Ильич", 1960, 1964),
                            new Ruler("Микоян Анастас Иванович", 1964, 1965),
                            new Ruler("Подгорный Николай Викторович", 1965, 1977),
                            new Ruler("Брежнев Леонид Ильич", 1977, 1982),
                            new Ruler("Кузнецов Василий Васильевич", 1982, 1983),
                            new Ruler("Андропов Юрий Владимирович", 1983, 1984),
                            new Ruler("Кузнецов Василий Васильевич", 1984, 1984),
                            new Ruler("Черненко Константин Устинович", 1984, 1985),
                            new Ruler("Кузнецов Василий Васильевич", 1985, 1985),
                            new Ruler("Громыко Андрей Андреевич", 1985, 1988),
                            new Ruler("Горбачёв Михаил Сергеевич", 1988, 1990),
                            new Ruler("Сталин Иосиф Виссарионович", 1922, 1953),
                            new Ruler("Хрущёв Никита Сергеевич", 1953, 1964),
                            new Ruler("Брежнев Леонид Ильич", 1954, 1982),
                            new Ruler("Андропов Юрий Владимирович", 1982, 1984),
                            new Ruler("Черненко Константин Устинович", 1984, 1985),
                            new Ruler("Горбачёв Михаил Сергеевич", 1985, 1991),
                            new Ruler("Ельцин Борис Николаевич", 1991, 1999),
                            new Ruler("Путин Владимир Владимирович", 1999, 2008),
                            new Ruler("Медведев Дмитрий Анатольевич", 2008, 2012),
                            new Ruler("Путин Владимир Владимирович", 2012, 2023)
                        };

                        int date;
                        Console.WriteLine("Введите дату правления (от 862 до 2023):");
                        while (!int.TryParse(Console.ReadLine(), out date))
                        {
                            Console.WriteLine("Ошибка ввода! Введите целое число");
                        }

                        if (date >= 862 && date <= 2023)
                        {
                            foreach (var ruler in russianRulers)
                            {
                                if ((ruler.beginOfReign <= date) && (ruler.endOfReign >= date))
                                {
                                    Console.WriteLine($"В этом году правил {ruler.name}.");
                                    Console.WriteLine($"Годы правления: {ruler.beginOfReign}-{ruler.endOfReign}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы введи некорректное значение (требуется год от 862 до 2023). Попробуйте ещё раз...");
                        }

                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion
                    case 4:
                        Console.WriteLine("\n\nЗавершение программы");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректное значение (требуется число от 1 до 4). Попробуйте ещё раз...");
                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (!exit);
        }

        static void IsPalindrome(string text)
        {
            text = text.ToLower();
            bool isPalindrome = false;
            if (text == null || text.Length == 0)
            {
                Console.WriteLine("Вы не ввели никакой текст");
            } else if (text.Length != 0)
            {
                isPalindrome = true;
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (text[i] != text[text.Length - i - 1])
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                    Console.WriteLine("Данный текст является палиндромом");
                else
                    Console.WriteLine("Данный текст не является палиндромом");
            }
            else
            {
                Console.WriteLine("Непредвиденная ошибка! Попробуйте повторить ввод. \nВ случае, если ошибка повторилась свяжитесь с разработчиком");
            }
        }
        static void Triangle(int[,] matrix1, int[,] matrix2, int[,] matrix3)
        {
            int side1 = -1;
            int side2 = -1;
            int side3 = -1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] > side1)
                        side1 = matrix1[i, j];
                    if (matrix2[i, j] > side2)
                        side2 = matrix2[i, j];
                    if (matrix3[i, j] > side3)
                        side3 = matrix3[i, j];
                }
            }

            Console.WriteLine("Длины сторон треугольника:");
            Console.WriteLine($"{side1}, {side2}, {side3}");

            if (side1 == 0 || side2 == 0 || side3 == 0) {
                Console.WriteLine("Треугольника нет");
                Console.WriteLine("Сторона не может равняться нулю");
            }
            else if (side1 + side2 < side3) {
                Console.WriteLine("Треугольника нет");
                Console.WriteLine($"{side3} > суммы других");
            }
            else if (side1 + side3 < side2) {

                Console.WriteLine("Треугольника нет");
                Console.WriteLine($"{side2} > суммы других");
            }
            else if (side2 + side3 < side1) {

                Console.WriteLine("Треугольника нет");
                Console.WriteLine($"{side1} > суммы других");
            }
            else
                Console.WriteLine("Треугольник есть");
        }
        static int[,] FillMatrixFromRandom(int[,] matrix, int minRand, int maxRand)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next(minRand, maxRand);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matrix[i, j] <= 9)
                        Console.Write(matrix[i, j] + "   ");
                    if (matrix[i, j] > 9)
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            return matrix;
        }
    }

    class Ruler {
        public string name { get; set; }
        public int beginOfReign { get; set; }
        public int endOfReign { get; set; }

        public Ruler(string name, int beginOfReign, int endOfReign)
        {
            this.name = name;
            this.beginOfReign = beginOfReign;
            this.endOfReign = endOfReign;
        }
    }
}