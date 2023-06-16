namespace GenericsDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //int result = FindMax.Maximum(55, 88, 33);
            //Console.WriteLine("maximum number is: " + result);

            // float result1 = FindMax.Maximumfloat(5.7f, 8.08f, 33.67f);
            //Console.WriteLine("maximum float is: " + result1);

            //String result2 = FindMax.MaximumString("Divya", "Priya", "Aakhansha");
            //Console.WriteLine("maximum string is: " + result2);

            FindMax<int> obj = new FindMax<int>(23, 50, 5);
            int result = obj.MaximumUsingGenerics(23, 50, 5);

            Console.WriteLine(result);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Greatest number among three numbers is :" + result);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

            FindMax<float> obj1 = new FindMax<float>(23.7f, 50.99f, 95.4f);
            float result1 = obj1.MaximumUsingGenerics(23.7f, 50.99f, 95.4f);

            Console.WriteLine(result1);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Greatest number among three numbers is :" + result1);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");


            FindMax<String> obj2 = new FindMax<String>("Divya", "Shweta", "Madhu");
            string result2 = obj2.MaximumUsingGenerics("Divya", "Shweta", "Madhu");

            Console.WriteLine(result1);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Greatest number among three numbers is :" + result2);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
        }
    }
}