using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char instruction = char.Parse(Console.ReadLine());
                if (instruction == '?')
                {
                    break;
                }
                else { }
                char data = char.Parse(Console.ReadLine());
                CPU list = new CPU(instruction, data);
            }
        }
    }
    class CPU
    {
        public char instruction;
        public char data;
        public CPU(char instructionValue, char dataValue)
        {
            instruction = instructionValue;
            data = dataValue;
        }
    }
    
}
