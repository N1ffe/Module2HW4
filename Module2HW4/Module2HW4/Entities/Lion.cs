using Module2HW4.Enums;

namespace Module2HW4.Entities
{
    public class Lion : Mammal
    {
        public Lion(int age, float height, float length, float weight)
            : base("Lion", age, height, length, weight, 10, DietEnum.Diet.Carnivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public Lion(int id, int age, float height, float length, float weight)
            : base(id, "Lion", age, height, length, weight, 10, DietEnum.Diet.Carnivore.ToString(), TemperatureRegulationEnum.TemperatureRegulation.WarmBlooded.ToString())
        {
        }
        public override object Clone()
        {
            return new Lion(Id, Age, Height, Length, Weight);
        }
    }
}
