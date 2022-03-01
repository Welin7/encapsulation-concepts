Console.WriteLine("Apply encapsulation concepts");

var person = new Encapsulation.Person("João Guilherme da Silva", 65, 1.66);

//Access via property public get
var imc = person.IMC;

Console.WriteLine();
Console.WriteLine(person);
Console.WriteLine();
Console.WriteLine($"The IMC of {person.Name} is of {imc}");
Console.ReadLine();
