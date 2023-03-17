namespace CSharp_MVC.CarInfo
{
    public class Car
    {
        public int Year { get; set; }
        public int Passengers { get; set; }
        public string? Direction { get; set; }
        public List<string> Wheels { get; set; } = new List<string>() { "LeftFront", "RightFront", "LeftRear", "RightRear" };
        public int Speed { get; set; }
        public virtual void Accelerate()
        {
            if (Speed <= 120)
            {
                Speed += 5;
            }
        }
        public void Decelerate()
        {
            if (Speed >= 5)
            {
                Speed -= 5;
            }
            else
            {
                Speed = 0;
            }
        }

        public void Decelerate(bool power)
        {
            if (power == true)
            {
                Speed = 0;
            }
        }

    }
}
