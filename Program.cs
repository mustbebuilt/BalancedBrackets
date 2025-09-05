namespace BalancedBrackets
{
    internal class Program
    {
        static bool areBracketsBalanced(string expr)
        {
            CharacterStack s=new CharacterStack(expr.Length);

            foreach (char c in expr)
            {
                if (c == '(' || c == '{' || c == '[')                
                    s.push(c); // push opening brackets                
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (s.isEmpty())
                        return false; // closing bracket with no matching opening

                    char top = s.pop();

                    // check if matching pair
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))                    
                        return false;                    
                }
            }

            if(s.isEmpty())
                return true; // all brackets matched
            else 
                return false;
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string expression = Console.ReadLine();

            if (areBracketsBalanced(expression))
                Console.WriteLine("Brackets are balanced.");
            else
                Console.WriteLine("Brackets are not balanced.");
        }                
    }
}