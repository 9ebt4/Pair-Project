using Pair_Project;
List<Person> duck = new List<Person>()
{
    new Person("Junyoung", 24),
    new Person("Carissa", 28),
    new Person("Ethan", 28),
};

foreach (Person p in duck)
{
    Console.WriteLine($"Name: {p.Name}  Age: {p.Age}");
}