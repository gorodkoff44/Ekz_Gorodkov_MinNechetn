using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz_Gorodkov_MinNechetn
{
    class Program
    {
		/// <summary>
		/// Контрольная работа
		/// Задача: Найти минимальный из элементов массива с нечетными индексами
		/// Автор: Городков Артём
		/// </summary>
		static void Main(string[] args)
        {
				Console.WriteLine("Задание: Найти минимальный из элементов массива с нечетными индексами");
				Console.WriteLine();
				Console.WriteLine("Введите длину массива");
				int m = int.Parse(Console.ReadLine());
				if (m < 1) //Проверка
				{
					Console.WriteLine("Длина массива не может быть меньше 1");
					return;
				}
				int[] mass = new int[m]; //Массив
				Random rnd = new Random(); //Случайные значения
				int r = rnd.Next(-100, 100); //Первое случайное значение
				int min; //Будет хранить минимальнле значение
				Console.WriteLine();
				Console.WriteLine("Массив:");
				//Console.WriteLine();
				for (int i = 0; i < m; i++) //Перебор индексов массива
				{
					mass[i] = r; //заполнение массива
					r = rnd.Next(-100, 100); //Следующее случайное значение
					Console.Write($"{mass[i]} [{i}]  ");
				}

				//Проверка на наличие первого нечетного индекса
				if (m > 1)
					min = mass[1];
				else
				{
					Console.WriteLine("Здесь нет чисел с нечетными индексами!");
					return;
				}
				for (int i = 1; i < m; ++i) //перебор нечетных индексов массива массива
				{
					if (mass[i] < min) //если значение меньше первого нечетного, то оно минимальное
					{
						min = mass[i];
					}
					++i; //пропуск четного значения
				}
				Console.WriteLine();
				Console.WriteLine($"Минимальное число с нечетным индексом: {min}");
				Console.ReadKey();
			}
    }
}
