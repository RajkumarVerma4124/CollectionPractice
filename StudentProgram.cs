namespace CollectionPractice
{
    public class StudentProgram
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Student Details => Id : {Id} Name : {Name} Age : {Age}";
        }
    }
}