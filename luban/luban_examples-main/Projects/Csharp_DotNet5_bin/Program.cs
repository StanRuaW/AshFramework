using Bright.Serialization;
using System;
using System.IO;
using System.Text.Json;

namespace Csharp_Server_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = new cfg.Tables(file => new ByteBuf(File.ReadAllBytes("../../../../GenerateDatas/bin/" + file + ".bin")));

            Console.WriteLine("== load succ ==");
        }
    }
}
