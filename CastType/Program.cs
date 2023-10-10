using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastType
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            bool myBool = (bool)myDouble; // nie da sie - double na bool
            string myString = "false";
            myBool = (bool)myString; // nie da sie - string na bool
            myString = (string)myInt; // nie da sie - int na string
            myString = myInt.ToString();
            myBool = (bool)myByte; // nie da sie - byte na bool
            myByte = (byte)myBool; // nie da sie - bool na byte
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar; // nie da sie - char na string
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;


        }
    }
}
