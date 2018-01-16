﻿/*
 * C# Program to Implement BinaryReader 
 */
using System;
using System.IO;

namespace binary_reader
{
    class ConsoleApplication
    {
        const string fileName = "program.dat";

        static void Main()
        {
            Write();
            Console.WriteLine("Using Binary Writer Class the Contents are Written");
            Display();
        }

        public static void Write()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"C:\Temp);
            }
        }

    }
}