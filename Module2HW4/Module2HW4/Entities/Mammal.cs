namespace Module2HW4.Entities
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
            : base(name, age, height, length, weight, lifespan, diet, temperatureRegulation)
        {
        }
        public Mammal(int id, string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
            : base(id, name, age, height, length, weight, lifespan, diet, temperatureRegulation)
        {
        }
        public override object Clone()
        {
            return new Mammal(Id, Name, Age, Height, Length, Weight, Lifespan, Diet, TemperatureRegulation);
        }
    }
}
