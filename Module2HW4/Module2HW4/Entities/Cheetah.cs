using Module2HW4.Enums;

namespace Module2HW4.Entities
{
    public class Cheetah : Mammal
    {
        public Cheetah(int age, float height, float length, float weight)
            : base("Cheetah", age, height, length, weight, 10, DietEnum.Diet.Carnivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public Cheetah(int id, int age, float height, float length, float weight)
            : base(id, "Cheetah", age, height, length, weight, 10, DietEnum.Diet.Carnivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public override object Clone()
        {
            return new Cheetah(Id, Age, Height, Length, Weight);
        }
    }
}
