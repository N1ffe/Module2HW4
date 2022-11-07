using Module2HW4.Entities;
using Module2HW4.Enums;
using Module2HW4.Extensions;
using Module2HW4.Services;
namespace Module2HW4
{
    public class Starter
    {
        public void Run()
        {
            int opt1;
            float fValue = 0;
            bool boolOpt;
            Animal?[] animals = { };
            string op = string.Empty, stringValue = string.Empty;
            ComparisonOperatorsEnum.Operators enumOp = ComparisonOperatorsEnum.Operators.LessThan;
            SafariPark safariPark = new SafariPark(new Section[] {
                new Section(
                    new Animal[] { new Lion(4, 1.2f, 2f, 190f), new Cheetah(5, 80f, 1.4f, 50f), new Giraffe(6, 5f, 4.2f, 900f) },
                    new SectionManager())
                // array of Bird class inheritors
                // array of Reptile class inheritors
            });
            safariPark.Sections[0].SectionManager.Show(safariPark.Sections[0].Animals, safariPark.Sections[0].Id);
            Console.WriteLine();
            Console.WriteLine("Choose parameter to sort by:\n1. Id\n2. Name\n3. Age\n4. Height\n5. Length\n6. Weight\n7. Lifespan\n8. Diet\n9. Temperature regulation");
            opt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Sort by:\n1. Ascending\n2. Descending");
            boolOpt = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()) - 1);
            Console.WriteLine();
            switch (opt1)
            {
                case 1:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Id, boolOpt);
                    break;
                case 2:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Name, boolOpt);
                    break;
                case 3:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Age, boolOpt);
                    break;
                case 4:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Height, boolOpt);
                    break;
                case 5:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Length, boolOpt);
                    break;
                case 6:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Weight, boolOpt);
                    break;
                case 7:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Lifespan, boolOpt);
                    break;
                case 8:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.Diet, boolOpt);
                    break;
                case 9:
                    safariPark.Sections[0].SectionManager.Sort(safariPark.Sections[0].Animals, AnimalParametersEnum.AnimalParameters.TemperatureRegulation, boolOpt);
                    break;
            }
            safariPark.Sections[0].SectionManager.Show(safariPark.Sections[0].Animals);
            Console.WriteLine();
            Console.WriteLine("Choose parameter to look for:\n1. Id\n2. Name\n3. Age\n4. Height\n5. Length\n6. Weight\n7. Lifespan\n8. Diet\n9. Temperature regulation");
            opt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (opt1 != 1 && opt1 != 8 && opt1 != 9)
            {
                Console.Write("Enter operator (<, <=, =, >, >=): ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "<":
                        enumOp = ComparisonOperatorsEnum.Operators.LessThan;
                        break;
                    case "<=":
                        enumOp = ComparisonOperatorsEnum.Operators.LessThanOrEqualTo;
                        break;
                    case "=":
                        enumOp = ComparisonOperatorsEnum.Operators.EqualTo;
                        break;
                    case ">":
                        enumOp = ComparisonOperatorsEnum.Operators.GreaterThan;
                        break;
                    case ">=":
                        enumOp = ComparisonOperatorsEnum.Operators.GreaterThanOrEqualTo;
                        break;
                }
            }
            Console.Write("Enter value: ");
            if (opt1 != 1 && opt1 != 8 && opt1 != 9)
            {
                fValue = (float)Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                stringValue = Console.ReadLine();
                Console.WriteLine();
            }
            switch (opt1)
            {
                case 1:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Id, enumOp, fValue);
                    break;
                case 2:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Name, stringValue);
                    break;
                case 3:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Age, enumOp, fValue);
                    break;
                case 4:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Height, enumOp, fValue);
                    break;
                case 5:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Length, enumOp, fValue);
                    break;
                case 6:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Weight, enumOp, fValue);
                    break;
                case 7:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Lifespan, enumOp, fValue);
                    break;
                case 8:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.Diet, stringValue);
                    break;
                case 9:
                    animals = safariPark.Sections[0].Animals.Find(AnimalParametersEnum.AnimalParameters.TemperatureRegulation, stringValue);
                    break;
            }
            if (animals.Length > 0)
            {
                safariPark.Sections[0].SectionManager.Show(animals);
            }
        }
    }
}
