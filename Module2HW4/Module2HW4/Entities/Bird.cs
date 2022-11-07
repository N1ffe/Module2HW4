namespace Module2HW4.Entities
{
    public class Bird : Animal
    {
        public Bird(string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
            : base(name, age, height, length, weight, lifespan, diet, temperatureRegulation)
        {
        }
        public Bird(int id, string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
            : base(id, name, age, height, length, weight, lifespan, diet, temperatureRegulation)
        {
        }
        public override object Clone()
        {
            return new Bird(Id, Name, Age, Height, Length, Weight, Lifespan, Diet, TemperatureRegulation);
        }
    }
}
