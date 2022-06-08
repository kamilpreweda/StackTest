namespace StackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("pierwszy na stosie");
            myStack.Push("drugi na stosie");
            myStack.Push("trzeci na stosie");
            myStack.Push("ostatni na stosie");

            // Metoda Peek działą dla stosu tak samo jak dla kolejki.
            Console.WriteLine($"Metoda Peek() zwróciła: \n{myStack.Peek()}");

            // Metoda Pop pobiera następny element z WIERZCHOŁKA stosu.
            Console.WriteLine($"Pierwsze wywołanie Pop() zwróciło: \n{myStack.Pop()}");
            Console.WriteLine($"Drugie wywołanie Pop() zwróciło: \n{myStack.Pop()}");

            Console.WriteLine($"Count przed wywołaniem Clear(): \n{myStack.Count()}");
            myStack.Clear();
            Console.WriteLine($"Count po wywołaniu Clear(): \n{myStack.Count()}");
        }

        

        
    }
}