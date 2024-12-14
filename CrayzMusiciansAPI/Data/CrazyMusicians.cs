namespace CrayzMusiciansAPI.Data
{
    public class CrazyMusicians
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Job { get; set; } = "";
        public string EnjoyProperty { get; set; } = "";
    }

    public static class Datlist // Müzisyen verilerini tutan statik bir sınıf.
    {
        public static List<CrazyMusicians> CrazyMusicians { get; } = new() // Statik bir liste oluşturulur, müzisyen verilerini içerir.

            {
                new CrazyMusicians { Id = 1, Name = "Ahmet Çalgı", Job = "Ünlü Çalgı Çalar", EnjoyProperty = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
                new CrazyMusicians { Id = 2, Name = "Zeynep Melodi", Job = "Popüler Melodi Yazarı", EnjoyProperty = "Şarkıları yanlış anlaşılır ama çok popüler" },
                new CrazyMusicians { Id = 3, Name = "Cemil Akor", Job = "Çılgın Akorist", EnjoyProperty = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
                new CrazyMusicians { Id = 4, Name = "Fatma Nota", Job = "Sürpriz Nota Üreticisi", EnjoyProperty = "Nota üretirken sürekli sürprizler hazırlar" },
                new CrazyMusicians { Id = 5, Name = "Hasan Ritim", Job = "Ritim Canavarı", EnjoyProperty = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
                new CrazyMusicians { Id = 6, Name = "Elif Armoni", Job = "Armoni Ustası", EnjoyProperty = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
                new CrazyMusicians { Id = 7, Name = "Ali Perde", Job = "Perde Uygulayıcı", EnjoyProperty = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
                new CrazyMusicians { Id = 8, Name = "Ayşe Rezonans", Job = "Rezonans Uzmanı", EnjoyProperty = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
                new CrazyMusicians { Id = 9, Name = "Murat Ton", Job = "Tonlama Meraklısı", EnjoyProperty = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
                new CrazyMusicians { Id = 10, Name = "Selin Akor", Job = "Akor Sihirbazı", EnjoyProperty = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
            };
    }
}

