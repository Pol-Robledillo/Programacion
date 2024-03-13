namespace ActividadesUF5
{
    public class Ex17
    {
        public static void Main()
        {
            BirdCounter birdCounter = new BirdCounter();
            birdCounter.BirdsPerDay = new int[] { 2, 5, 0, 7, 4, 1 };
            birdCounter.LastWeek();
            Console.WriteLine(birdCounter.Today());
            birdCounter.IncrementTodaysCount();
            birdCounter.LastWeek();
            Console.WriteLine(birdCounter.HasDayWithoutBirds());
            Console.WriteLine(birdCounter.TotalBirds());
            Console.WriteLine(birdCounter.BusyDays());
        }
    }
}