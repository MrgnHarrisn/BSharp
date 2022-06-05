using System;

namespace myproject
{
    class Program {

        static void Main(String[] args) {
            Run(args[1]);
        }

        static void Run(String file) {

            // Create the lexer
            Lexer lexer = new Lexer(openFile(file));
            Parser parser = new Parser();
            // turn the program into
            parser.addTokens(lexer.lex());
            parser.parse();

        }

        static string openFile(String file) {
            string output = "";
            string[] lines = System.IO.File.ReadAllLines(@file);
            foreach(string s in lines) {
                output += s + "\n";     // we need the \n because it doesn't record the new lines
            }
            return output;
        }

    }
}