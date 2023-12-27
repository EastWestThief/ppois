public class Appraiser : Human
{
    public int ExperienceYears { get; set; } // Опыт работы в годах

    // Метод для оценки картины
    public double AppraisePainting(Picture painting)
    {
        // Например, мы можем оценивать картину на основе года создания и опыта оценщика
        double Value = painting.Year.Year * ExperienceYears;

        return Value;
    }

    public bool IsOriginal(Picture painting, List<Picture> allPaintings)
    {
        // Ищем картины с таким же названием
        var sameTitlePaintings = allPaintings.Where(p => p.Title == painting.Title).ToList();

        // Если нет других картин с таким же названием, то картина оригинальна
        if (sameTitlePaintings.Count == 1)
        {
            return true;
        }

        // Если есть другие картины с таким же названием, сравниваем год создания
        foreach (var sameTitlePainting in sameTitlePaintings)
        {
            if (sameTitlePainting.Year.CompareTo(painting.Year) < 0)
            {
                // Если найдена картина с таким же названием и более ранним годом создания, то картина не оригинальна
                return false;
            }
        }

        // Если не найдено других картин с таким же названием и более ранним годом создания, то картина оригинальна
        return true;
    }
}

