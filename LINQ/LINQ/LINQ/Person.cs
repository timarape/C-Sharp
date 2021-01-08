namespace LINQ
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _weight;
        private int _height;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Heigt { get => _height; set => _height = value; }
        private Gender _gender;

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public Person(string firstName, string lastName, int weight, int height, Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _weight = weight;
            _height = height;
            _gender = gender;

        }
    }
}
