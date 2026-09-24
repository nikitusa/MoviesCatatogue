using _0zadanie;
using System.Text.Json;

string path = "C:\\Users\\ninovikov\\Desktop\\test.txt";
string hello = "Привет,файл!";
File.WriteAllText(path, hello);
Console.WriteLine(File.ReadAllText(path));




Console.WriteLine("Какое имя?");
string name = Console.ReadLine();
Console.WriteLine("Какой возраст?");
string inputUserAge = Console.ReadLine();
bool check = int.TryParse(inputUserAge, out int age);
Person person = new Person(name,age);
string json = JsonSerializer.Serialize<Person>(person);
Console.WriteLine(json);





FileStream readStream = File.OpenRead(path);
StreamReader streamReader = new StreamReader(readStream);
//streamReader.Read

Person persona = JsonSerializer.Deserialize<Person>();


