namespace OrderedLinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            //OrderList orderList = new OrderList();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            //orderList.Ordered(word);
            ParenthesesProgram parenthesesProgram = new ParenthesesProgram();
            parenthesesProgram.checkBalanced(word);
        }
    }
}