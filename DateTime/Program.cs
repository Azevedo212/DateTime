using System; 

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2023,07,28);
        DateTime d2 = new DateTime(2023,07,28);

        //d1.Compare(d2);
        // 0 - datas iguais
        // -1 - a primeira data é anterior a segunda
        // 1 - a primeira data é posterior a segunda

        int retornoComaparaDatas = DateTime.Compare(d1, d2);

        if(retornoComaparaDatas == 0 )
        {
            Console.WriteLine("São iguais");
        }



        /* Console.Write("Informe a data de nascimento: ");
         DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
         Console.WriteLine(dataNasc.DayOfWeek); 

         DateTime d3 = d1.AddDays(10);
         DateTime d4 = d2.AddYears(2);

         Console.WriteLine(DateTime.Now);
         Console.WriteLine(DateTime.UtcNow); 


        TimeSpan a = new TimeSpan(6053, 00, 00, 00);

        DateTime novadata = DateTime.Now.Subtract(a);

        Console.WriteLine(novadata); */

        DateTime d5 = DateTime.Parse("07/04/2022");
        DateTime d6 = DateTime.Parse("07-04-2022");

        Console.WriteLine(d5);
        Console.WriteLine(d6);

    }
}