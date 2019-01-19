namespace SimpleWebScrapper
{
    class Person
    {
        public Person(string firstName, string lastName, int age, int eyeColor, int hairColor)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EyeColor = eyeColor;
            HairColor = hairColor;
        }
  
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
        public int EyeColor { get; set; }
        public int HairColor { get; set; }

    }
}
