public class Gallery
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }
    public List<Exhibition> Exhibitions { get; set; }
    public List<Picture> Storage { get; set; }

    public Gallery()
    {
        Storage = new List<Picture>();
    }
    public Picture RequestPainting(Artist artist, string title, string technique, int size)
    {
        // Галерея генерирует запрос на картину
        Picture requestedPainting = new Picture()
        {
            Title = title,
            Authors = new List<Artist> { artist }, // Желаемый художник
            Technique = technique,
            Size = size
        };
        // Запрос передается художнику, и он создает картину по этим параметрам
        artist.CreateRequestPainting(requestedPainting);

        // Возвращаем запрошенную картину
        return requestedPainting;
    }
    public void AddPictureToStorage(Picture picture)
    {
        if (picture.CurrentGallery != null)
        {
            throw new Exception("Картина уже находится в другой галерее.");
        }
        else
        {
            Storage.Add(picture);
            picture.CurrentGallery = this;
        }
    }

    public void RemovePictureFromStorage(Picture picture)
    {
        if (Storage.Contains(picture))
        {
            Storage.Remove(picture);
            picture.CurrentGallery = null;
        }
        else
        {
            throw new Exception("Картина не находится в хранилище этой галереи.");
        }
    }
    public void AddExhibition(Exhibition exhibition)
    {
        if (exhibition.CurrentGallery != null)
        {
            throw new Exception("Выставка уже проводится в другой галерее.");
        }
        else
        {
            Exhibitions.Add(exhibition);
            exhibition.CurrentGallery = this;
        }
    }

    public void RemoveExhibition(Exhibition exhibition)
    {
        if (Exhibitions.Contains(exhibition))
        {
            Exhibitions.Remove(exhibition);
            exhibition.CurrentGallery = null;
        }
        else
        {
            throw new Exception("Выставка не проводится в этой галерее.");
        }
    }
}

