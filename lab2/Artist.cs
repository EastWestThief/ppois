using System;
public class Artist : Human
{
    public string Nationality { get; set; }
    public Data BirthYear { get; set; }
    public Data DeathYear { get; set; }
    public List<Picture> Paintings { get; set; }

    public void CreatePainting(string title, Data yearOfCreation, string technique, int size)
    {
        Picture newPainting = new Picture()
        {
            Title = title,
            Authors = new List<Artist> { this }, // Этот художник является одним из авторов
            Year = yearOfCreation,
            Technique = technique,
            Size = size
        };
    }

    public void ExhibitPainting(Picture painting, Exhibition exhibition)
    {
        // Проверяем, является ли этот художник автором картины
        if (!painting.Authors.Contains(this))
        {
            throw new Exception("Художник может выставлять только свои картины.");
        }

        // Добавляем картину на выставку
        if (!exhibition.Paintings.Contains(painting))
        {
            exhibition.Paintings.Add(painting);
        }
    }

    public void CreateRequestPainting(Picture painting)
    {
        // Художник создает новую картину по параметрам из запроса
        Paintings.Add(painting);
    }

    public Picture CreateReplica(Picture original, Data yearOfCreation)
    {
        // Создаем реплику оригинальной картины
        Picture replica = new Picture()
        {
            Title = original.Title,
            Authors = new List<Artist> { this }, // Этот художник является автором реплики
            Year = yearOfCreation, // Год создания реплики - текущий год
            Technique = original.Technique,
            Size = original.Size,
            IsOriginal = false // Пометка о том, что это реплика
        };

        // Добавляем реплику в список картин художника
        Paintings.Add(replica);

        return replica;
    }

    public void Tour(Exhibition exhibition)
    {
        // Проверяем, есть ли картины этого художника на выставке
        var artistPaintings = exhibition.Paintings.Where(p => p.Authors.Contains(this)).ToList();

        if (artistPaintings.Count > 0)
        {
            Console.WriteLine($"На выставке \"{exhibition.Name}\" представлены следующие мои ({this.Name}) работы:");

            foreach (var painting in artistPaintings)
            {
                Console.WriteLine($"Название: {painting.Title}");
                Console.WriteLine($"Год создания: {painting.Year.GetDate()}");
                Console.WriteLine($"Техника: {painting.Technique}");
                Console.WriteLine($"Размер: {painting.Size}");
                Console.WriteLine($"Оригинальность: {(painting.IsOriginal ? "Оригинал" : "Реплика")}");
                Console.WriteLine("--------------------");
            }
        }
        else
        {
            Console.WriteLine($"На выставке \"{exhibition.Name}\" нет моих ({this.Name}) работ.");
        }
    }
}





