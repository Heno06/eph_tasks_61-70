namespace eph_tasks_61_70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int first_digit = a / 1000;
            int second_digit = a % 1000 / 100;
            int third_digit = a % 100 / 10;
            int fourth_digit = a % 10;
            Console.WriteLine(third_digit + fourth_digit == second_digit + first_digit ? true : false);
            int sum1 = second_digit + fourth_digit;
            int sum2 = first_digit + third_digit;          
            Console.WriteLine(a > 5000 ? a / sum1 : a / sum2);
            Console.WriteLine(first_digit == 1 || second_digit == 0 || third_digit == 0 || fourth_digit == 0 ? 1 : 0);
            Console.WriteLine(sum1 == 5 ? "s" : "d");
            Console.WriteLine(sum1 == 12 ? "y=12" : "y=0");
            Console.WriteLine(first_digit == 4 || fourth_digit == 4 ? "YES" : "NO");
            Console.WriteLine((a == ((sum2 + sum1) ^ 2)) ? "YES" : "NO");
            Console.WriteLine(fourth_digit > third_digit ? fourth_digit * third_digit : 1);
            Console.WriteLine(sum1 + sum2 > 20 ? "1" : "0");
            Console.WriteLine(first_digit * second_digit * third_digit * fourth_digit > 200 ? "0" : "1");
        }
    }
}
