
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region 1 ci tapsiriq

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine(a + " " + "boyukdur");
//}

//else if (b > a)
//{
//    Console.WriteLine(b + " " + "boyukdur");
//}

//else
//{
//    Console.WriteLine("ededler beraberdir");
//}

#endregion


#region 2 ci tapsiriq

//int a;
//Console.WriteLine(" a ni daxil et :");
//a = Convert.ToInt32(Console.ReadLine());


//if (a % 2 == 0)
//{
//    Console.WriteLine(a + " " + "ededi 2 ye bolunur");
//}

//else
//{
//    Console.WriteLine(" eded 2 ye bolunmur");
//}
#endregion


#region 3 cu tapsiriq

//int a;
//Console.WriteLine("ededi daxil et :");
//a = Convert.ToInt32(Console.ReadLine());

//if (a >= 100)
//{
//    Console.WriteLine("boyuk");
//}

//else
//{
//    Console.WriteLine("kicik");
//}
#endregion


#region 4 cu tapsiriq

//int a;
//Console.WriteLine("yasi daxil et :");
//a = Convert.ToInt32(Console.ReadLine());

//if (a >= 18)
//{
//    Console.WriteLine("Adult");
//}

//else if (a < 18)
//{
//    Console.WriteLine("Child");
//}

#endregion


#region 5 ci tapsiriq
//int a;
//Console.WriteLine("ededi daxil et :");
//a = Convert.ToInt32(Console.ReadLine());

//if (a > 0)
//{
//    Console.WriteLine("eded musbetdir");
//}
//else if (a < 0)
//{
//    Console.WriteLine("eded menfidir");
//}
//else
//{
//    Console.WriteLine("0 ne musbet nede menfidir");
//}
#endregion

#region 6 ci tapsiriq

//int num;
//Console.WriteLine("ededi daxil et");
//num = Convert.ToInt32(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;

//    case 2:
//        Console.WriteLine("Monday");
//        break;

//    case 3:
//        Console.WriteLine("Tuesday");
//        break;

//    case 4:
//        Console.WriteLine("Wednesday");
//        break;

//    case 5:
//        Console.WriteLine("Thursday");
//        break;

//    case 6:
//        Console.WriteLine("Friday");
//        break;

//    case 7:
//        Console.WriteLine("Saturday");
//        break;

//    default:
//        Console.WriteLine("Invaid day");
//        break;

//}
#endregion


#region 7 ci tapsireiq

//int a;
//Console.WriteLine("ededi daxil et");
//a = Convert.ToInt32(Console.ReadLine());

//int result = a*a*a;

//Console.WriteLine("netice :" + " " + result);

#endregion


#region 8 ci tapsiriq


//int num;

//Console.WriteLine("ayi daxil et");
//num = Convert.ToInt32(Console.ReadLine());

//switch (num)
//{
//    case 1: case 3: case 5: case 7: case 8: case 10: case 12
//        Console.WriteLine("31 gun");
//        break;

//    case 2:
//        Console.WriteLine("28 gun");
//        break;

//    

//    case 4: case 6: case 9: case 11:
//        Console.WriteLine("30 gun");
//        break;


//    default:
//        Console.WriteLine("ay duzgun daxil edilmeyib");
//        break;


//}

#endregion

#region 9 cu tapsiriq

//string[] fruits = { "alma", "armud", "banan", "çiyələk", "albalı", "şaftalı", "portağal", "mandarin", "qarpız", "qovun" } 


#endregion

#region 10 cu tapsiriq

//string[] students = { "Əli", "Nigar", "Murad", "Aysel", "Tural", "Leyla", "Rəşad", "Günel", "Elvin", "Zəhra" };


#endregion



//Console.WriteLine("ededi daxil et :");
//int a = Convert.ToInt32(Console.ReadLine());


//if (a % 1 != 0 && a % a != 0)
//{
//    Console.WriteLine(a + "ededi Prime deyil");
//}
//else
//{
//    Console.WriteLine(a + "ededi Prime dir");
//}

#region 17 ci tapsiriq

//int[] numbers = { 23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 6 == 0)
//    {
//        Console.WriteLine("6 ya bolunenler :" + numbers[i]);
//    }

//}
#endregion

#region 19 cu tapsiriq

//double b;
//double endirim;

//double[] Prices = { 100.0, 1300.50, 259.99, 430.30, 160.99, 320.0 };

//for (int i = 0; i < Prices.Length; i++)
//{

//    endirim = Prices[i] - Prices[i] * 0.2; ;
//    Console.WriteLine(endirim);
//}

#endregion

#region 20 ci tapsiriq 

//int[] userage = { 23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57 };

//for(int i = 0; i < userage.Length; i++)
//{
//    if (userage[i] >= 65)
//    {
//        Console.WriteLine("yasi"+" "+ userage[i]+ " "+ "olan sexs teqaude ayrilmalidir");
//    } 
//}

#endregion



#region 18 ci tapsiriq


//Console.WriteLine("a ni daxil et :");
//Console.WriteLine("b ni daxil et :");
//Console.WriteLine("+");
//Console.WriteLine("*");
//Console.WriteLine("-");
//Console.WriteLine("/");
//Console.WriteLine("^");



//double a = Convert.ToInt32(Console.ReadLine());
//double b = Convert.ToInt32(Console.ReadLine());
//string op = Console.ReadLine();


//switch (op)
//{
//    case "+":
//        Console.WriteLine(a + b);
//        break;

//    case "*":
//        Console.WriteLine(a * b);
//        break;

//    case "-":
//        Console.WriteLine(a - b);
//        break;

//    case "/":
//        if(b ==0)
//        {
//            Console.WriteLine("0 ra bolmek okmaz!!!");
//        }
//        else
//        {
//            Console.WriteLine(a / b);

//        }
//        break;


//    case "%":
//    if (b ==0)
//    {
//        Console.WriteLine("0 ra bolmek okmaz!!!");
//    }
//    else
//    {
//        Console.WriteLine(a % b);

//    }
//    break;

//case "^":
//    Console.WriteLine(Math.Pow(a, b));
//    break;

//default:
//    Console.WriteLine("sehv operator");
//    break;


//}
#endregion

#region 21 ci tapsiriq

Console.WriteLine("1 ci terefi daxil et:");
Console.WriteLine("2 ci terefi daxil et:");
Console.WriteLine("3 cu terefi daxil et:");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if ((a*a + b*b == c*c) || (a*a + c*c == b*b) || (b*b + c*c == a*a))
{
    Console.WriteLine("duzbucaqli ucbucaqdir");
}

else
{
    Console.WriteLine("duzbucaqli ucbucaq deyil");
}

if ((a == b && b != c && a != c ) || (a == c && a != b && c != b) || (b == c && b != a && a != c))
{
    Console.WriteLine("bereaber yanli ucbucaqdir");
}
else
{
    Console.WriteLine("bereaber yanli ucbucaq deyil;");
}


if ((a == b && b == c && a == c) || (a == c && a == b && c == b) || (b == c && b == a && a == c))
{
    Console.WriteLine("bereaber terefli ucbucaqdir");
}
else
{
    Console.WriteLine("bereaber terefli ucbucaq deyil;");
}


















# endregion



























