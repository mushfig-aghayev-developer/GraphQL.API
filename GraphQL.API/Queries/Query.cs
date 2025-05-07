namespace GraphQL.API.Queries
{
    public class Query
    {
        public string GetPersonInfo() //scalar
        {
            return "Michael Jackson";
        } 
        public string GetPersonInfoParams(string name) //complex
        {
            return $"{name} Jackson";
        }

        public List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person(1, "Michael Juli"),
                new Person(2, "John Commo"),
                new Person(3, "David Guetta")
            };
        }
    }

    public record Person(int Id, string name);
}
