namespace GenericsDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int result = FindMax.Maximum(55, 88, 33);
            Console.WriteLine("maximum number is: " + result);

            float result1 = FindMax.Maximumfloat(5.7f, 8.08f, 33.67f);
            Console.WriteLine("maximum float is: " + result1);


        }
    }
}