
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
        static void Statistiche(ref double[] pesi,ref double media,ref double min,ref double max)
        {
            min = pesi[0];
            max = pesi[0];
            double somma = 0;
            for(int i = 0;i< pesi.Length; i++)
            {
                somma += pesi[i];
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
            }
            media=somma/pesi.Length;
        }


    }
}
