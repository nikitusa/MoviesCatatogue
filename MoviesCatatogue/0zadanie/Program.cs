using _0zadanie;
using System.Text.Json;
Person[] Person = new Person[3];
string[] people = new string[3];



//ЗАДАЧА ЧАСТЬ 0 ШАГ 1



string path = "C:\\Users\\ninovikov\\Desktop\\test.txt";
string path2 = "C:\\Users\\ninovikov\\Desktop\\people.json";
string hello = "Привет,файл!";
File.WriteAllText(path, hello);
Console.WriteLine(File.ReadAllText(path));


//ЧАСТЬ 0 ШАГИ 2 И 3



Console.WriteLine("Какое имя?");
string? name = Console.ReadLine();
Console.WriteLine("Какой возраст?");
string? inputUserAge = Console.ReadLine();
bool check = int.TryParse(inputUserAge, out int age);
Person person = new Person(name, age);
string? json = JsonSerializer.Serialize<Person>(person);
Console.WriteLine(json);
Person persona = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(persona.Name);
Console.WriteLine(persona.Age);


//ЧАСТЬ 0 ШАГ 4 


for (int i = 0; i < Person.Length; i++)
{
    Console.WriteLine("Какое имя?");
    name = Console.ReadLine();
    Console.WriteLine("Какой возраст?");
    inputUserAge = Console.ReadLine();
    check = int.TryParse(inputUserAge, out age);
    Person[i] = person;
}

string json2 = JsonSerializer.Serialize<Person[]>(Person);
File.WriteAllText(path2, json2);
string jsonFromFile = File.ReadAllText(path2);
Person[] OutputPerson = JsonSerializer.Deserialize<Person[]>(jsonFromFile);
for (int i = 0; i < OutputPerson.Length; i++)
{
    Console.WriteLine(OutputPerson[i]);
}




//ЗАДАЧА 1.3!!




float max = 0;
Console.WriteLine("Сколько хотите ввести чисел");
string inputCountUser = Console.ReadLine();
bool check2 = int.TryParse(inputCountUser, out int countNumbers);
float[] array = new float[countNumbers];
float avg = 0;
float sigma = 0;
float staples = 0;
float fraction = 0;
float avgsimple = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = Random.Shared.Next();
}
float min = array[0];
for (int i = 0; i < array.Length; i++) 
{
    
    min = float.MinNumber(min, array[i]);
    max = float.MaxNumber(max, array[i]);
    avgsimple = avgsimple + array[i] / array.Length;
    avg = MathF.Round(avgsimple, 1);
    staples = staples + MathF.Pow(array[i] - avgsimple, 2);

}

fraction = staples / array.Length - 1;
sigma = MathF.Sqrt(fraction);
Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine($"Максимальное значение: {max}");
Console.WriteLine($"Среднее арифметическое значение округленное до 1 знака: {avg}");
Console.WriteLine($"разброс значений — среднеквадратичное отклонение : {sigma}");



// ЗАДАЧА 1.1

float[] aLotOfNumbersarray = new float[10];
float[] bubleSort = new float[10];
float[] insertionSort = new float[10];
float[] selectionSort = new float[10];
for (int i = 0; i < aLotOfNumbersarray.Length; i++)
{
    aLotOfNumbersarray[i] = Random.Shared.Next();
    Console.Write(aLotOfNumbersarray[i] + " ");
}


// Задача 1.2!!





for (int i = 0; i < aLotOfNumbersarray.Length; i++)
{
    float[] vivod = (SortArray.SetBubleSort(aLotOfNumbersarray));
    Console.Write("ПУЗЫРЕК" + " " + vivod[i] + " ");
}
for (int i = 0; i < aLotOfNumbersarray.Length; i++)
{
    float[] vivod = (SortArray.SetInsertionSort(aLotOfNumbersarray));
    Console.Write("ВСТАВКИ" + " " + vivod[i] + " ");
}
for (int i = 0; i < aLotOfNumbersarray.Length; i++)
{
    float[] vivod = (SortArray.SetSelectionSort(aLotOfNumbersarray));
    Console.Write("ВЫБОРОМ" + " " + vivod[i] + " ");
}




void OutputSortArrays() 
{
   
    
}