namespace GetPropertiesfromInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "hussein",
                Score = 91
            };

            var propertiesInfo = student.GetType().GetProperties();
            foreach (var property in propertiesInfo)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(student);
                Console.WriteLine($"{propertyName} : {propertyValue}");
            }
        }
    }
}