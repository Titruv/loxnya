  class Program
{
 static void Main() //2 commit
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine($"Task 1: {string.Join(", ", result)}");
        }
}
