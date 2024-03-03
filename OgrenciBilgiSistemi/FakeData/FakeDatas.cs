using Bogus;
using OgrenciBilgiSistemi.Models;

namespace OgrenciBilgiSistemi.FakeData
{
    public class FakeDatas
    {
        public static List<Student> GenerateStudent(int count)
        {
            var students = new Faker<Student>()
                            .RuleFor(students => students.Name, x => x.Name.FirstName())
                            .RuleFor(students => students.Surname, x => x.Name.LastName())
                            .RuleFor(st => st.StudentClass, x => x.PickRandom("A", "B", "C"))
                            .Generate(count);

            return students;
        }
    }
}
