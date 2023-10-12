/*
// Challenge 1
List<string> Names = new List<string>();

bool AmProgrammer = true; //no debe llevar comillas
double Age = 27.9; //la variable age no se esta utilizando
string nombre = "Monica"; //se debe agregar el tipo de variable
Console.WriteLine(Names);

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");

// This is a tricky one! Hint: look up what a char is in C#
string MyName = 'MyName';

// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = 0; i < Numbers.Count; i--); // estaba mal la sintaxys del bucle for 
{
    Console.WriteLine(Numbers);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i); // se estaba intentando accerder al indice, y debe acceder atravez de sus elementos
}


// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
for (int i = 0; i < EvenMoreNumbers.Count; i++) // se intenta modificar la variable en el foreach lo que no se puede realizar en C#
//realice un cambio a bucle for para poder acceder a los elementos por el indice y modificarlos
{
    if(EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
}


// Challenge 5
// What can we learn from this error message?
// se esta tratando de asignar un valor a un caracter en el objeto string y para modificarlo debe convertir en un arreglo para poder modificarlo o separarlo por una lista
string MyString = "superduberawesome";
//MyString[7] = "p";
*/

// Challenge 6
// Hint: some bugs don't come with error messages

Random rand = new Random();
int randomNum = rand.Next(12); // no hay error pero no se cumple la condicion deberia colarse un numero mayor a 12
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}


