using Module2HW4.Interfaces;

namespace Module2HW4.Entities
{
    public class Section : ISection
    {
        private static int id;
        public Section(Animal[] animals, ISectionManager sectionManager)
        {
            Id = ++id;
            Animals = animals;
            SectionManager = sectionManager;
        }
        public int Id { get; set; }
        public Animal[] Animals { get; set; }
        public ISectionManager SectionManager { get; set; }
    }
}
