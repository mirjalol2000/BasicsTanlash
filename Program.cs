// See https://aka.ms/new-console-template for more information
//1. String ustidda amallar
/*string str = "teleFon";
int x;
x = Convert.ToInt32(Console.ReadLine());
int len = str.Length;
if(x>len) { Console.WriteLine(str.ToUpper()); }
else { Console.WriteLine(str.ToLower()); }*/

//2.Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
/*int x = 15;
int y = 10;

if(x > y)
{
    Console.WriteLine("x is greater than y");
}
else if(x < y) 
{
    Console.WriteLine("x is less than y");
}
else if(x == y)
{
    Console.WriteLine("x is equal to y");
}
else Console.WriteLine("x and y are not comparable");*/
// 3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib,
// natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
Console.WriteLine("Hafta kunini kiriting : ");
string s = Console.ReadLine();

string result = s switch
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
};
Console.WriteLine(result);
