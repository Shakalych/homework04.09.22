//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Тут будет 2 варианта!

void FillArray(int[] numbers)
{
    //Console.WriteLine("Введи массив: ");
    for(int index = 0; index < numbers.Length; index++)
        numbers[index] = new Random().Next(1, 51);  //Произвольный массив
        //numbers[index] = Convert.ToInt32(Console.ReadLine()); //Ручной ввод массива
}

void PrintArray(int[] num)
{
    for(int position = 0; position < num.Length; position++)
        Console.Write(num[position] + ", ");    
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.Write("=> ");
PrintArray(array);

