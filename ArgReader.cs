﻿using System.Diagnostics;

namespace DawnLangCompiler
{
    class ArgReader
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[0] == "-d")
                    Tokenization.DebugMode = true;
                if (args[i] == "-b")
                    Tokenization.BuildFile(args[i + 1], args[i + 2]);
                if (args[i] == "-br")
                {
                    Tokenization.BuildFile(args[i + 1], args[i + 2]);
                    Process.Start("./" + args[i + 2]);
                }
            }
        }
    }
}