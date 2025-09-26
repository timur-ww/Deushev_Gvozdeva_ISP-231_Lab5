// Шаг 1. Методы и их параметры

/*
void SayHello() => Console.WriteLine("Hello");*/



/*void SayHello(){
    Console.WriteLine("Hello");
}*//*
SayHello();*/

/*Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.Write("Введите ваш язык: ");
string lan = Console.ReadLine().ToLower();

void SayhelloRU() => Console.WriteLine($"Привет {name}");

void SayhelloEN() => Console.WriteLine($"Hello {name}");

void SayhelloDE() => Console.WriteLine($"Guten Tag {name}");

switch(lan) {
    case "русский": SayhelloRU(); break;
    case "английский": SayhelloEN(); break;
    case "немецкий": SayhelloDE(); break;
    default: Console.WriteLine("Ошибка ввода"); break;
}*/

/*void Game() {
    Console.Write("Введите любимую игру: ");
    string myGame = Console.ReadLine();
    Console.WriteLine($"Ваша любимая  игра: {myGame}");
}

Game();*/


/*void Print(string message) {
    Console.WriteLine(message);
}
Print("Hello");*/

/*void Sum(int x, int y) {
    int res = x + y;
    Console.WriteLine(res);
}
Sum(12, 20);
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

Sum(x, y);*/

/*void PrintPerson(string personname = "Неизвестно", string name, int age, string vuz) {
    Console.WriteLine($"Имя: {name}, возраст: {age}, вуз: {vuz}");
}

PrintPerson(name: "Ника",age: 18, vuz: "Вф волгу");
PrintPerson(vuz: "Вф волгу", age: 18, name: "Ника");*/

// Шаг 2. Возвращения значения и оператор return

/*string GetMassage () {
    return "Hello";
}
int GetNum () {
    return 10;
}

int GetNumm() => 4;

var res = GetMassage();
Console.WriteLine(res);
Console.WriteLine(GetMassage());*/

/*int Sum(int a, int b) => a + b;
Sum(10, 20);
Console.WriteLine(Sum);
Console.WriteLine(Sum(10,30));*/

/*Console.WriteLine("Введите ваш возраст : ");
int age = Convert.ToInt32(Console.ReadLine());*/

/*void Check(int num) {
    if(num < 0) {
        Console.WriteLine("Отрицательное");
        return; 
    }
    Console.WriteLine("Положительное");
   
}
Check(num);*/

// Шаг 3. Метод Random

/*Random random = new Random();
int num = random.Next(1, 100);
Console.WriteLine(num);*/

// Шаг 4. Мини-проект: Погодный информатор

/*void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать на прогноз погоды");
void ShowGoodbyeMessage() => Console.WriteLine("До свидания");

string GetWeather() {
    string[] weather = ["Солнечно", "Пасмурно", "Дождливо", "Снежно", "Ураган"];
    Random random = new();
    int index = random.Next(weather.Length);
    return weather[index];
}

ShowWelcomeMessage();
Console.WriteLine($"Погода на сегодня {GetWeather()}");
ShowGoodbyeMessage();*/

// Шаг 5. Рекурсивные функции

/*int Factorial(int n) {
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));
*/

// Шаг 7. Локальные функции

/*void Compare(int[] num1, int[] num2)
{
    int num1Sum = 0;
    int num2Sum = 0;

    foreach (int i in num1)
        num1Sum += i;

    foreach (int j in num1)
        num1Sum += j;

    if (num1Sum > num2Sum)
        Console.WriteLine("сумма чисел из массива num1 больше");
    else if (num1Sum < num2Sum)
        Console.WriteLine("сумма чисел из массива num2 больше");
    else
        Console.WriteLine("сумма чисел двух массивово равны");

    int Sum(int[] nums)
    {
        int res = 0;
        foreach (int i in nums)
            res += i;
        return res;
    }
}

int[] num1 = [1, 2, 3];
int[] num2 = [3, 4, 5, 6, 7];
Compare(num1, num2);*/

// Шаг 8. Статические локальные функции


/*int Sum(int[] nums)
{
    int limit = 0;
    int res = 0;

    static bool IsPassed(int num, int lim)
    {
    return num > lim;
    }

    foreach (int i in nums)
    {
    if (IsPassed(i, limit)) res += i;
    }     

    foreach (int i in nums)
    {
        if (IsPassed(i)) res += i;
    }

    return res;
    
    bool IsPassed(int i)
    {
        return i > limit;
    }
}

int[] num1 = [-3, -2, -1, 0, 1, 2, 3];
int[] num2 = [3, -4, 5, -6, 7];
Console.WriteLine(Sum(num1));
Console.WriteLine(Sum(num2));*/

// Самостоятельные задания

// Задание 1. Тест

// 1 - Ничего
// 2 - void ShowWelcomeMessage()
// 3 - Метод вызовет ошибку компиляции
// 4 - void PrintNumber(int number)
// 5 - PrintMessage('Hello, World!')

// Задание 2. Метод приветствия

/*void GreetUser()
{
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}! Добро пожаловать в программу!");
}

GreetUser();*/

// Задание 3. Сумма двух чисел

/*int AddNumbers (int num1, int num2)
{
    return num1 + num2;
}

Console.Write("Введите первое число: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine(AddNumbers(x1, x2));*/

// Задание 4. Проверка чётности

/*bool IsEven(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }

    else
    {
        return false;
    }
}

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(IsEven(x));*/

// Задание 5. Поиск максимума в массиве

/*int FindMax(int[] nums)
{
    int max = nums[0];
    foreach (int i in nums)
    {
        if (i > max)
        {
            max = i;
        }
    }

    return max;
}

int[] nums = [2, 4, 6, 3, -1];

Console.WriteLine(FindMax(nums));*/

// Задание 6. Цельсия в Фаренгейты

/*double ConvertCelsiusToFahrenheit (double c)
{
    return c * 9 / 5 + 32;
}

Console.Write("Введите градусы цельсия: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine(ConvertCelsiusToFahrenheit(c));*/

// Задание 7. Подсчёт гласных в строке

/*int CountVowels (string text)
{
    int count = 0;
    foreach (char i in text)
    {
        if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
        {
            count += 1;
        }
    }
    return count;
}

Console.Write("Введите слово на англиском: ");
string txt = Console.ReadLine();

Console.WriteLine(CountVowels(txt));*/

// Задание 8. Генератор случайного пароля

/*string GeneratePassword(int length)
{
    if (length <= 0)
        return "Длина пароля должна быть больше 0";

    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "abcdefghijklmnopqrstuvwxyz" + "0123456789";

    Random random = new Random();

    string pass = "";

    for (int i = 0; i < length; i++)
    {
        int index = random.Next(chars.Length);
        pass += chars[index];
    }

    return pass;

 }


Console.Write("Введите длину пароля: ");
int l = int.Parse(Console.ReadLine());

Console.WriteLine($"Пароль: {GeneratePassword(l)}");*/

// Задание 9. Проверка палиндрома

/*bool IsPalindrome(string text)
{
    string cl = text.ToLower().Replace(" ", "");
    char[] chars = cl.ToCharArray();
    Array.Reverse(chars);
    string rev = new string(chars);

    return cl == rev;
}

Console.Write("Введите слово: ");
string text = Console.ReadLine();
Console.WriteLine(IsPalindrome(text));*/

// Задание 10. Разворот массива

/*int[] ReverseArray(int[] nums)
{
    int[] rev = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        rev[i] = nums[nums.Length - 1 - i];
    }

    return rev;

}

int[] nums = [1, 2, 4, 5, 6];
Console.WriteLine(string.Join(", ", ReverseArray(nums)));*/

// Задание 11. Калькулятор

/*double Add(double x, double y) => x + y;
double Sub(double x, double y) => x - y;
double Mul(double x, double y) => x * y;
double Div(double x, double y) => x / y;

Console.Write("Ввыберите действие: \n[+] 1 \n[-] 2 \n[*] 3 \n[/] 4 \n=> ");
string znak = Console.ReadLine(); 

switch (znak)
{
    case "1":
        Console.Write("Введите первое число: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Резльтат - {Add(x, y)}");
        break;

    case "2":
        Console.Write("Введите первое число: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Резльтат - {Sub(x, y)}");
        break;

    case "3":
        Console.Write("Введите первое число: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Резльтат - {Mul(x, y)}");
        break;

    case "4":
        Console.Write("Введите первое число: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Резльтат - {Div(x, y)}");
        break;

    default:
        Console.WriteLine("Ошибка ввода");
        break;
}*/


// Задание 12. Поиск простых чисел

/*bool IsPrime(int n)
{
    if (n < 2) return false;

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0) return false;
    }

    return true;
}

void PrintPrimesUpTo(int n)
{
    for (int i = 2; i < n; i++)
    {
        if (IsPrime(i))
            Console.WriteLine(i);
    }
}

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
PrintPrimesUpTo(n);*/