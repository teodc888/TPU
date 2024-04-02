
Console.WriteLine("Nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Edad");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Sexo");
string sexo = Console.ReadLine();
Console.WriteLine("Peso");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Altura");
float altura = float.Parse(Console.ReadLine()); 

Persona.Persona persona  = new Persona.Persona(nombre, edad, sexo, peso, altura);

Console.WriteLine("IMC: " + persona.CalcularIMC());

Console.WriteLine("MAYOR DE EDAD: " + persona.EsMayorDeEdad());

