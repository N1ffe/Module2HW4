using Module2HW4.Entities;
using Module2HW4.Interfaces;
using static Module2HW4.Enums.AnimalParametersEnum;

namespace Module2HW4.Services
{
    public class SectionManager : ISectionManager
    {
        public int GetAnimalCount(Animal[] array)
        {
            return array.Length;
        }
        public void Show(Animal?[] array, int id = -1)
        {
            if (id >= 0)
            {
                Console.WriteLine($"Section {id}:");
            }
            foreach (Animal animal in array)
            {
                if (animal is null)
                {
                    break;
                }
                Console.WriteLine($"Id: {animal.Id}, Name: {animal.Name}, Age: {animal.Age}, Height: {animal.Height}, Length: {animal.Length}, " +
                    $"Weight: {animal.Weight}, Lifespan: {animal.Lifespan}, Diet: {animal.Diet}, Temperature regulation: {animal.TemperatureRegulation}");
            }
        }
        public void Sort(Animal[] array, AnimalParameters parameter, bool reverse = false)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    switch (parameter)
                    {
                        case AnimalParameters.Id:
                            if ((array[j].Id > array[j + 1].Id && !reverse) || (array[j].Id < array[j + 1].Id && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Name:
                            if ((array[j].Name.ToLower()[0] > array[j + 1].Name.ToLower()[0] && !reverse) || (array[j].Name.ToLower()[0] < array[j + 1].Name.ToLower()[0] && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Age:
                            if ((array[j].Age > array[j + 1].Age && !reverse) || (array[j].Age < array[j + 1].Age && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Height:
                            if ((array[j].Height > array[j + 1].Height && !reverse) || (array[j].Height < array[j + 1].Height && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Length:
                            if ((array[j].Length > array[j + 1].Length && !reverse) || (array[j].Length < array[j + 1].Length && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Weight:
                            if ((array[j].Weight > array[j + 1].Weight && !reverse) || (array[j].Weight < array[j + 1].Weight && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Lifespan:
                            if ((array[j].Lifespan > array[j + 1].Lifespan && !reverse) || (array[j].Lifespan < array[j + 1].Lifespan && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.Diet:
                            if ((array[j].Diet.ToLower()[0] > array[j + 1].Diet.ToLower()[0] && !reverse) ||
                                (array[j].Diet.ToLower()[0] < array[j + 1].Diet.ToLower()[0] && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case AnimalParameters.TemperatureRegulation:
                            if ((array[j].TemperatureRegulation.ToLower()[0] > array[j + 1].TemperatureRegulation.ToLower()[0] && !reverse)
                                || (array[j].TemperatureRegulation.ToLower()[0] < array[j + 1].TemperatureRegulation.ToLower()[0] && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                    }
                }
            }
        }
        private void SwitchTwo(Animal[] array, int i)
        {
            Animal animal1 = (Animal)array[i].Clone();
            Animal animal2 = (Animal)array[i + 1].Clone();
            array[i] = animal2;
            array[i + 1] = animal1;
        }
    }
}
