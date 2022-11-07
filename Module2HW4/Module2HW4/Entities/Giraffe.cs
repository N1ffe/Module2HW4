using Module2HW4.Enums;

namespace Module2HW4.Entities
{
    public class Giraffe : Mammal
    {
        public Giraffe(int age, float height, float length, float weight)
            : base("Giraffe", age, height, length, weight, 25, DietEnum.Diet.Herbivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public Giraffe(int id, int age, float height, float length, float weight)
            : base(id, "Giraffe", age, height, length, weight, 25, DietEnum.Diet.Herbivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public override object Clone()
        {
            return new Giraffe(Id, Age, Height, Length, Weight);
        }
    }
}
