// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

string [] UserDeterminedArray()
{
    Console.Write("Input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string [] array  = new string [size];

    for(int i=0; i<size; i++)
    {
        Console.Write($"Input element of array with index = {i}: ");
        array[i]= Console.ReadLine()??string.Empty;
    }
    return array;
}

string [] SelectedByConditionArray(int symbolsCount, string[] array)
{
    int resultArraySize=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            resultArraySize++;
        }
        
    }
    string [] resultArray = new string[resultArraySize];
    for(int i=0, j=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            resultArray[j]=array[i];
            j++;
        }
        
    }
    return resultArray;
}

void ShowArray(string [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=0){
            Console.Write(", ");
        }
        Console.Write($"{array[i]}");
    }
     Console.Write("]");
}

string[] array =UserDeterminedArray();

Console.Write("Input symbols count for new arrays element: ");
int symbolsCount = Convert.ToInt32(Console.ReadLine());
string [] newArray = SelectedByConditionArray(symbolsCount, array);
ShowArray(newArray);

