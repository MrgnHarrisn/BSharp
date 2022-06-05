class Lexer
{

    private string filecontents;

    public Lexer(string filecontents)
    {
        this.filecontents = filecontents;
        // Console.WriteLine(filecontents);
    }

    public List<Object> lex()
    {

        // this stores te tokns in a way that the computer will be able to understand
        List<Object> tokens = new List<Object>();

        string tok = "";
        bool strStart = false;
        string str = "";

        foreach (char c in filecontents)
        {
            tok += c;

            // ignore whitespace
            if (tok == " ")
            {
                if (strStart == false) {
                    tok = "";
                } else {
                    tok = " ";
                }
            }

            else if (tok == "\n") {
                tok = "";
            }

            // For when we find a print statement
            else if (tok == "print")
            {
                tokens.Add("PRINT");
                tok = "";
            }

            else if (tok == "\"") {
                if (!strStart) {
                    strStart = true;
                } else if (strStart) {
                    tokens.Add("STRING:" + str + "\"");
                    str = "";
                    strStart = false;
                    tok = "";
                }
            }

            else if (strStart == true) {
                str += tok;
                tok = "";
            }

        }
        // print(tokens);
        return tokens;
    }

    void print(List<Object> tokens) {
        Console.WriteLine(string.Join(", ", tokens));
    }

}