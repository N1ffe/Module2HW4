using Module2HW4.Entities;

namespace Module2HW4.Interfaces
{
    public interface ISection
    {
        int Id { get; set; }
        Animal[] Animals { get; set; }
        ISectionManager SectionManager { get; set; }
    }
}
