namespace Module2HW4.Entities
{
    public abstract class Animal : ICloneable
    {
        private static int id;
        protected Animal(string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
        {
            Id = ++id;
            Name = name;
            Age = age;
            Height = height;
            Length = length;
            Weight = weight;
            Lifespan = lifespan;
            Diet = diet;
            TemperatureRegulation = temperatureRegulation;
        }
        protected Animal(int id, string name, int age, float height, float length, float weight, int lifespan, string diet, string temperatureRegulation)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Length = length;
            Weight = weight;
            Lifespan = lifespan;
            Diet = diet;
            TemperatureRegulation = temperatureRegulation;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public int Lifespan { get; set; }
        public string Diet { get; set; } // herbivore, carnivore, omnivore
        public string TemperatureRegulation { get; set; } // warm-blooded, cold-blooded
        public abstract object Clone();
    }
}
