using Module2HW4.Entities;
using static Module2HW4.Enums.AnimalParametersEnum;
using static Module2HW4.Enums.ComparisonOperatorsEnum;

namespace Module2HW4.Extensions
{
    public static class AnimalsExtension
    {
        public static Animal?[] Find(this Animal[] array, AnimalParameters parameter, Operators op, float value)
        {
            Animal?[] result = new Animal?[array.Length];
            int i = 0;
            foreach (Animal animal in array)
            {
                switch (parameter)
                {
                    case AnimalParameters.Id:
                        if (Compare(animal.Id, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Age:
                        if (Compare(animal.Age, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Height:
                        if (Compare(animal.Height, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Length:
                        if (Compare(animal.Length, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Weight:
                        if (Compare(animal.Weight, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Lifespan:
                        if (Compare(animal.Lifespan, value, op))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                }
            }
            return result;
        }
        public static Animal?[] Find(this Animal[] array, AnimalParameters parameter, string value)
        {
            Animal?[] result = new Animal?[array.Length];
            int i = 0;
            foreach (Animal animal in array)
            {
                switch (parameter)
                {
                    case AnimalParameters.Name:
                        if (animal.Name.Contains(value))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.Diet:
                        if (animal.Diet.Contains(value))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                    case AnimalParameters.TemperatureRegulation:
                        if (animal.TemperatureRegulation.Contains(value))
                        {
                            i += Func(result, i, animal);
                        }
                        break;
                }
            }
            return result;
        }
        private static bool Compare(float value1, float value2, Operators op)
        {
            switch (op)
            {
                case Operators.LessThan:
                    return value1 < value2;
                case Operators.LessThanOrEqualTo:
                    return value1 <= value2;
                case Operators.EqualTo:
                    return value1 == value2;
                case Operators.GreaterThan:
                    return value1 > value2;
                case Operators.GreaterThanOrEqualTo:
                    return value1 >= value2;
                default:
                    return false;
            }
        }
        private static int Func(Animal?[] array, int i, Animal animal)
        {
            array[i] = animal;
            return 1;
        }
    }
}
