class Parser
{

    private List<Object> tokens = new List<Object>();

    public Parser() {}

    public Parser(List<Object> tokens) {
        this.tokens = tokens;
    }

    public void parse() {
        // print(tokens);

        for (int i = 0; i < tokens.Count(); i++) {
            // print(tokens[i]);
            if (tokens[i] + " " + tokens[i+1].ToString().Substring(0, 6) == "PRINT STRING") {
                string temp = tokens[i+1].ToString();
                int length = -8 + temp.Length - 1;
                Console.WriteLine(temp.Substring(8, length));
                i++;
            }
        }

    }

    public void addTokens(List<Object> tokens) {
        this.tokens = tokens;
    }

    void print(List<Object> tokens) {
        Console.WriteLine(string.Join(", ", tokens));
    }

    void print(Object o) {
        Console.WriteLine(o.ToString());
    }

}