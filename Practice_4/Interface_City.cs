using CSharp.Classes;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

City Kyiv = new();
Kyiv.PrintInfo();

Kyiv.EditInfo();
Kyiv.PrintInfo();