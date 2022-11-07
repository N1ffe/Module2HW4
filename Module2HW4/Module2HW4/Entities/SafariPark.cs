namespace Module2HW4.Entities
{
    public class SafariPark
    {
        public SafariPark(Section[] sections)
        {
            Sections = sections;
        }
        public Section[] Sections { get; set; }
    }
}
