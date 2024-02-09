using System;

namespace List5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int med = 0;
            List<int> salaries = new List<int>();
            while (true)
            {
                Console.WriteLine("Skriv in din månadslön");
                int svar = int.Parse(Console.ReadLine());
                if ((svar) == 0)
                {
                    break;
                }
                else
                {
                    salaries.Add(svar);
                }
            }
            for (int i = 0; i < salaries.Count; i++)
            {
                sum += salaries[i];
            }
            salaries.Sort();
            if (salaries.Count % 2 == 0)
            {
                med = (salaries[salaries.Count/2 - 1] + salaries[salaries.Count/2]) / 2;
            }
            else
            {
                med = salaries[salaries.Count / 2];
            }
            Console.WriteLine("Din medel lön är " + (sum / salaries.Count) + " och din median är " + med);
        }
    }
}