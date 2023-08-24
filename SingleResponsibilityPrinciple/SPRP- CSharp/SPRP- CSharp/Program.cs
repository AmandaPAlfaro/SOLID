using SPRP__CSharp;


namespace SPRP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalorieTracker calorieTracker = new CalorieTracker(2000);
              

            calorieTracker.trackCalories(500); 
            calorieTracker.trackCalories(1000);
            calorieTracker.trackCalories(700);
        }

        public class CalorieTracker
        {
           
            public int maxCalories;
            public int currentCalories;

            public CalorieTracker(int maxCalories)
            {
                this.maxCalories = maxCalories;
                this.currentCalories = 0;
            }

            public void trackCalories(int calorieCount)
            {
                Logger logger = new Logger();
                this.currentCalories += calorieCount;
                if (this.currentCalories > this.maxCalories)
                {
                    Logger.LogMessage();
                }
            }
        }
    }
}
