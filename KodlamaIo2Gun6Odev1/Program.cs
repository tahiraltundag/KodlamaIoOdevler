using System;

namespace KodlamaIo2Gun6Odev1 {
    class Program {

        static void Main(string[] args) {


            Videos videos1 = new Videos("can patlar ve şarkılar","Flunk-Down-Türkçe Altyazılı",7000,2);

            Videos videos2 = new Videos("zamana karşı", "Jake & Sadie - Another Love(11.22.63)", 14000, 1);

            Videos videos3 = new Videos("Perdenin Ardındakiler", "Perdenin Ardındakiler - Beni Kendinden Kurtar", 34000000, 2);


            Videos[] videos = new Videos[] { videos1, videos2, videos3};

            foreach(Videos video in videos) {
                Console.WriteLine(video.Name + "\n" + video.PublisherName + "\n"
                                  + video.NumberOfViews + "\n" + video.ReleaseDate);
            }

            Console.ReadLine();
        }

    }

    class Videos {

        public Videos(string name, string publisherName, int numberOfView, int releaseDate) {
            Name = name;
            PublisherName = publisherName;
            NumberOfViews = numberOfView;
            ReleaseDate = releaseDate;
        }
        public string Name { get; set; }
        public string PublisherName { get; set; }
        public int NumberOfViews { get; set; }
        public int ReleaseDate { get; set; }
    }
}
