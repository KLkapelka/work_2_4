// используя Dictionary<key, value>. В качестве ключей используйте названия месяцев,
// а в качестве значений – массив температур по дням. Напишите метод, который используя данные из словаря
// вычислит среднюю температуру для каждого месяца, и вернет словарь(Dictionary)
// средних температур (В качестве ключа название месяца, в качестве значения коллекция средних температура);


using System;
using System.Linq; 
class work_2_4
{
  static void Main()
    {
        float[,] temperatures = new float[12, 30]; 
        Random rand = new Random(); 

        for (int iRow = 0; iRow < 12; iRow++)
        {
            
            if (iRow <= 2) 
                for (int iCol = 0; iCol < 30; iCol++) 
                {
                    temperatures[iRow, iCol] = rand.Next(-35, 1); 
                }
            else if (iRow <= 8) 
            { 
                for (int iCol = 0; iCol < 30; iCol++)
                {
                    temperatures[iRow, iCol] = rand.Next(-5, 15); 
                }
            }
            else 
            {
                for (int iCol = 0; iCol < 30; iCol++) 
                {
                    temperatures[iRow, iCol] = rand.Next(10, 35); 
                }
            }
        }

        float[] medium = CalculateМedium(temperatures); 

        Array.Sort(medium); 

        Console.WriteLine("Средние температуры по возрастанию:");
        foreach (var i in medium)
        {
            Console.WriteLine(i);
        }
    }


    static float[] CalculateМedium(float[,] temperatures)
    {
        int months = temperatures.GetLength(0); 
        int days = temperatures.GetLength(1);

        float[] medium = new float[months]; 

        for (int iRow = 0; iRow < months; iRow++)
        {
            float sum = 0; 
            
            for (int iCol = 0; iCol < days; iCol++)
            {
                sum += temperatures[iRow, iCol];
            }

            medium[iRow] = sum / days;
        }

        return medium; 
    }
}