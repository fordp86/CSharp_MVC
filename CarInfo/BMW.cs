namespace CSharp_MVC.CarInfo
{
    public class BMW : Car
    {
        public string? Make { get { return "BMW"; } }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal FuelLevel { get; set; }

        private decimal Boost = 0.10M;

        public override void Accelerate()
        {
            if(Speed <= 130)
            {
                Speed += 5 + (int)(Speed * Boost);
            }
        }

        public void Decelerate(bool power)
        {
            if(power == true)
            {
                Speed = 0;
            }
        }
    }
}
