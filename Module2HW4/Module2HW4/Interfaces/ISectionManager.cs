using Module2HW4.Entities;
using static Module2HW4.Enums.AnimalParametersEnum;

namespace Module2HW4.Interfaces
{
    public interface ISectionManager
    {
        int GetAnimalCount(Animal[] array);
        void Show(Animal?[] array, int id = -1);
        void Sort(Animal[] array, AnimalParameters parameter, bool reverse = false);
    }
}
