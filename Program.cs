
#region Task4
/*while (true)
{
    Console.Write("Number is: ");
    int number;
    var isNumber = int.TryParse(Console.ReadLine(), out number);
    if (isNumber)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
        break;
    }
    else
    {
        Console.WriteLine("This is Not Number, Enter Right Number!");
    }
}*/
#endregion

#region Task5
/*
int side1 = lengthOfSide("Enter the length of the first side: ");
int side2 = lengthOfSide("Enter the length of the second side: ");
int side3 = lengthOfSide("Enter the length of the third side: ");


if (side1 == side2 & side2 == side3)
{
    triangleAllSidesAreEqual();
    Console.WriteLine("[triangle] All sides are equal");

}
else if (side1 == side2 & side2 != side3 || side1 == side3 & side2 != side3 || side3 == side2 & side1 != side3)
{
    triangleTwoEqualSides();
    Console.WriteLine("[triangle] two equal sides");

}
else
{
    triangleUnequalٍides();
    Console.WriteLine("[triangle] Unequal sides");
}

int lengthOfSide(string message)
{
    int value;
    while (true)
    {
        Console.Write(message);
        var isNumber = int.TryParse(Console.ReadLine(), out value);
        if (!isNumber)
        {
            Console.WriteLine("Enter Right Number!");
        }
        else
        {
            break;
        }
    }
    return value;
}
void triangleTwoEqualSides()
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

void triangleAllSidesAreEqual()
{
    for (int i = 1; i <= 8; i++)
    {
        for (int k = 0; k < 8 - i; k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < i; j++)
        {

            Console.Write("* ");

        }

        Console.WriteLine();
    }

}
void triangleUnequalٍides()
{
    for (int i = 1; i <= 8; i++)
    {
        for (int k = 0; k < 8 - i; k++)
        {
            Console.Write("  ");
        }
        for (int j = 0; j < i; j++)
        {

            Console.Write("*  ");

        }

        Console.WriteLine();
    }

}
*/
#endregion

#region Task6
/*string[] names = { "Essa" , "Ahmed" , "Mohamed" , "Salah" , "Sayed" , "Leel" };
Console.Write("Enter Name: ");
string name = Console.ReadLine();
for (int i = 0; i < names.Length; i++)
{
    if (names[i].ToLower() == name.ToLower())
    {
        Console.WriteLine("This Name Is Exist!");
        break;
    }
    if(i == names.Length-1)
    {
        throw new Exception("This Name Not Exist!!!!!!!!!!!!!!!!!!");
    }
}
*/

#endregion

#region Task 7. Bonus
/*
    int[] arrOfNumbers = new int[3];
    arrOfNumbers[0] = inputNumber(1);
    arrOfNumbers[1] = inputNumber(2);
    arrOfNumbers[2] = inputNumber(3);
   
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < arrOfNumbers[j]; k++)
        {
            Console.Write($"{arrOfNumbers[j]} ");
        }
        Console.WriteLine();
    }


int inputNumber( int i){
    Console.Write($"Enter number {i}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}*/
#endregion

#region Bonus
/*
int[] arrOfNumbers = new int[5];
int total = 0;
for (int i = 0; i < arrOfNumbers.Length; i++)
{
    receiveNumber(i + 1);
    total += arrOfNumbers[i];
    if (i == 4)
    {
        Console.WriteLine($"The sum of the numbers in the list {total}");
    }
}
void receiveNumber(int i)
{
    int number;

    Console.Write($"Enter Number {i}: ");
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out number);
    if (!isNumber)
    {
        string[] splitArray = input.Select(Char.ToString).ToArray();
        string finalValue = "";
        int testNumber;
        for (int j = 0; j < splitArray.Length; j++)
        {
            for (int k = 0; k < 1; k--)
            {
                bool itemIsNumber = int.TryParse(splitArray[j], out testNumber);
                if (!itemIsNumber)
                {
                    Console.Write($"Replace {splitArray[j]}: ");
                    string value = Console.ReadLine();
                    splitArray[j] = value;
                }
                else
                {
                    break;
                }
            }
        }
        for (int j = 0; j < splitArray.Length; j++)
        {
            finalValue += splitArray[j];
        }
        number = int.Parse(finalValue);
        arrOfNumbers[i - 1] = number;
    }
    else
    {
        arrOfNumbers[i - 1] = number;

    }

}*/

#endregion