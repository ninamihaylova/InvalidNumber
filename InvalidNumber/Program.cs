class InvalidNumber
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        Boolean isValid = number >= 100 && number <= 200 || number == 0;
        if (!isValid) {
            Console.WriteLine("invalid");
        }
    }
}