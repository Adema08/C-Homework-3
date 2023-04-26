// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Сделала не только для пятизначного
void Palindrom(string s)
{
    int count = 0;
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] == s[s.Length - i - 1])
        {
            count++;
        }
        else
        {
            System.Console.WriteLine("No");
            break;
        }
    }
    if (count == s.Length / 2)
    {
        System.Console.WriteLine("Yes");
    }
}

System.Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(n);
Palindrom(s);
