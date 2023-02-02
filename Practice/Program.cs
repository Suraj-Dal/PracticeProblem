namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] a = { 16, 11 };
            //int[] b = { 14, 21 };
            //PairIntersection pairIntersection = new PairIntersection();
            //int[] result = pairIntersection.Pair_Intersection(a, b);
            //Console.WriteLine("Intersection Points are [" + result[0] + "," + result[1] + "]");

            //int[] arr = { 1, 4, 3, 6, 8, 7, 9, 2, 5, 0, 12, 23 };
            //int n = arr.Length;
            //Pyramid py = new Pyramid();
            //int[] result = py.Pyramid_Arrangement(arr, n);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //VendingMachine machine = new VendingMachine();
            //machine.getChange(2.99, 5);

            int[][] booked = new int[3][];
            booked[0] = new int[2] { 10, 12 };
            booked[1] = new int[2] { 14, 16 };
            booked[2] = new int[2] { 22, 24 };

            TimeSlot timeSlot = new TimeSlot();
            timeSlot.getAppoinment(booked);
        }
    }
}
