public class Picture
{
    public string Title { get; set; }
    public List<Artist> Authors { get; set; }
    public Data Year { get; set; }
    public string Technique { get; set; }
    public int Size { get; set; }
    public bool IsOriginal { get; set; }
    public Gallery CurrentGallery { get; set; }

    public Picture()
    {
        Authors = new List<Artist>(); // Инициализация списка
        IsOriginal = true; // По умолчанию все картины считаются оригинальными
    }

    public void DisplayAllPaintings(List<Picture> allPaintings)
    {
        foreach (var painting in allPaintings)
        {
            Console.WriteLine($"Название: {painting.Title}");
            Console.WriteLine("Авторы:");
            foreach (var author in painting.Authors)
            {
                Console.WriteLine(author.Name);
            }
            Console.WriteLine($"Год создания: {painting.Year.GetDate()}");
            Console.WriteLine($"Техника: {painting.Technique}");
            Console.WriteLine($"Размер: {painting.Size}");
            Console.WriteLine($"Оригинальность: {(painting.IsOriginal ? "Оригинал" : "Реплика")}");
            Console.WriteLine("--------------------");
        }
    }
}


