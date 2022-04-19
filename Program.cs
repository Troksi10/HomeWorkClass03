// See https://aka.ms/new-console-template for more information


Console.WriteLine("============ Task 1 ==================");

// Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:
//*Test Data:
//    *Enter integer no.1:
//  *4
// * Enter integer no.1:
//  *3
// * Enter integer no.1:
//  *7
// Enter integer no.1:
//  *3
// * Enter integer no.1:
// *2
// * Enter integer no.1:
// *8
//* Expected Output:
//  *The result is: 14

int[] numbersInput = new int[6];
int result = 0;

for (int i = 0; i < numbersInput.Length; i++)
{
    Console.WriteLine("Enter integer no.1");
    numbersInput[i] = int.Parse(Console.ReadLine());
    if(numbersInput[i] % 2 == 0)
    {
        result += numbersInput[i];
    }
    else
    {
        Console.WriteLine("Odd Number");
    }
}

Console.WriteLine($"The result is :{result}");


Console.WriteLine("===================== Task 2 ===========================");

// Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };


string[] studentsG2 = { "Petre", "Angel", "Vase", "Martina", "Bojan" };

Console.WriteLine("Please enter student group : (there are 1 and 2 )");

int userInput = int.Parse(Console.ReadLine());

if (userInput == 1)
{
    foreach (string firstGroupStudents in studentsG1)
    {
        Console.WriteLine(firstGroupStudents);
    }
}
else if (userInput == 2)
{
    foreach (string secondGroupStudents in studentsG2)
    {
        Console.WriteLine(secondGroupStudents);
    }
}
else
{
    Console.WriteLine("Wrong input please enter (1 or 2 )");
}


Console.ReadLine();


