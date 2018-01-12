using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine().ToLower();
        long result = 0;
        while (opCode != "end")
        {
            switch (opCode)
            {
                case "inc":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int result1 = operandOne+1;
                        Console.WriteLine(result1);
                        break;
                    }
                case "dec":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int result2 = operandOne- 1;
                        Console.WriteLine(result2);
                        break;
                    }
                case "add":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int operandTwo = int.Parse(Console.ReadLine());
                        int result3 = operandOne + operandTwo;
                        Console.WriteLine(result3);
                        break;
                    }
                case "mla":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int operandTwo = int.Parse(Console.ReadLine());
                        long result4 = (long)(operandOne * operandTwo);
                        Console.WriteLine(result4);
                        break;
                    }
                    opCode = Console.ReadLine();
            }
        }      
    }
}