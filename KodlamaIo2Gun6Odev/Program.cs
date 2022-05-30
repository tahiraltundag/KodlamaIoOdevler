using System;

namespace KodlamaIo2Gun6Odev {
    class Program {
        static void Main(string[] args) {


            Course course1 = new Course("ASP.NET MVC Yazılımcıların Yükselişi", "Murat Baseren", 4.6, 249.99);
            
            Course course2 = new Course("Android Mobil Uygulama Kursu: Kotlin & Java","Atıl Samancioglu",4.7 ,289.99);

            Course course3 = new Course("Python | Sıfırdan İleri Seviye Programlama", "Mustafa Murat Coşkun", 4.5, 249.99);


            Course[] courses = new Course[] { course1, course2, course3};


            foreach(Course course in courses) {
                Console.WriteLine();
                Console.WriteLine(course.Name + "\n" + course.TrainerName + "\n" + course.AverageNumberOfStars + "\n" + course.Price);
            }

            Console.ReadLine();

        }

    }

    class Course {

        public Course(string name, string trainerName, double averageNumberOfStars, double price) {
            Name = name;
            TrainerName = trainerName;
            AverageNumberOfStars = averageNumberOfStars;
            Price = price;
        }

        public string Name { get; set; }
        public string TrainerName { get; set; }
        public double AverageNumberOfStars { get; set; }
        public double Price { get; set; }

        
    }
}
