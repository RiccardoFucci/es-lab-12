
namespace es_lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire la dimensione");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[dim];
            double[] pesi = new double[dim];
            int[] età = new int[dim];
            CaricaVettori(ref pesi, ref età);
        }

        static void CaricaVettori(ref double[] pesi,ref int[] età)
        {
            Random random = new Random();
            for(int i = 0; i < età.Length; i++)
            {
                pesi[i] = random.Next(50,101);
                età[i] = random.Next(18, 100);
            }
        }
    }
}
