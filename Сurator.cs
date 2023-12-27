public class Сurator : Human
{
    public string Nationality { get; set; }
    public List<Exhibition> Shows { get; set; }

    

    public void OrganizeExhibition(string name, Data startDate, Data finishDate, List<Picture> paintings)
    {
        Exhibition newExhibition = new Exhibition()
        {
            Name = name,
            StartDate = startDate,
            FinishDate = finishDate,
            Paintings = paintings,
        };

        Shows.Add(newExhibition);
    }

    public void AddArtistPaintingsToExhibition(Artist artist, Exhibition exhibition)
    {
        // Добавляем все картины художника на выставку
        foreach (var painting in artist.Paintings)
        {
            if (!exhibition.Paintings.Contains(painting))
            {
                exhibition.Paintings.Add(painting);
            }
        }
    }
}


