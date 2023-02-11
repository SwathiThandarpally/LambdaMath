namespace LambdaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
             Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIs_LessThanEighteen(listPersonInCity);
            Retrieving_AverageAge(listPersonInCity);
            CheckNameIsPresent(listPersonInCity);
            DispalyAgeGreaterThansixty(listPersonInCity);
            RemoveSpecificName(listPersonInCity);

        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("222222", "Sam", "12 main road", 15));
            listPersonInCity.Add(new Person("222222", "Ram", "13 main road", 25));
            listPersonInCity.Add(new Person("222222", "Tom", "14 main road", 85));
            listPersonInCity.Add(new Person("222222", "Jam", "12 main road", 45));
            listPersonInCity.Add(new Person("222222", "Zam", "12 main road", 12));
            listPersonInCity.Add(new Person("222222", "Cam", "12 main road", 14));
            listPersonInCity.Add(new Person("222222", "Bam", "12 main road", 75));
            listPersonInCity.Add(new Person("222222", "Mam", "12 main road", 18));

            Console.WriteLine("---------------------------------");
        }
             
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e=>(e.Age<60)).Take(2))
            {
                Console.WriteLine("Name : " + person.Name + "Age :" + person.Age);
            }
            Console.WriteLine("---------------------------------");
        }
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanEighteen(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 18 && e.Age>13)))
            {
                Console.WriteLine("Name : " + person.Name + "Age :" + person.Age);
            }
            Console.WriteLine("---------------------------------");
        }
        private static void Retrieving_AverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine(avgAge);

            Console.WriteLine("---------------------------------");
        }

        private static void CheckNameIsPresent(List<Person> listPersonInCity)
        {
            bool check = listPersonInCity.Any(e => e.Name == "Tom");
            if(check)
            {
                Console.WriteLine("Name is present");
            }
            else
            {
                Console.WriteLine("Name is not  present");
            }
            Console.WriteLine("---------------------------------");
        }
        private static void DispalyAgeGreaterThansixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e=>(e.Age>60)))
            {
                Console.WriteLine("Name :" + person.Name + "Age :" + person.Age);
            }
            Console.WriteLine("---------------------------------");
        }
        private static void RemoveSpecificName(List<Person> listPersonInCity)
        {
            int check = listPersonInCity.RemoveAll(e => e.Name == "Tom");
            foreach (Person person in listPersonInCity)
            {
                Console.WriteLine("Name :" + person.Name + "Age :" + person.Age);
            }
        }

    }
}