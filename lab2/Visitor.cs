public class Visitor : Human
{
    public List<Exhibition> Shows { get; set; }

    public void LeaveComment(Exhibition exhibition, string text, Data date)
    {
        if (Shows.Contains(exhibition))
        {
            Comment comment = new Comment
            {
                Date = date,
                Text = text,
                Author = this,
            };

            exhibition.Comments.Add(comment);
        }
        else
        {
            throw new Exception("Посетитель не может оставить комментарий о выставке, которую он не посещал.");
        }
    }

    public void VisitExhibition(Exhibition Name)
    {
        if (!Shows.Contains(Name))
        {
            Shows.Add(Name);
        }
        else
        {
            throw new Exception("Посетитель уже посещал эту выставку.");
        }
    }

    public string FindPicture(Picture picture)
    {
        foreach (var exhibition in Shows)
        {
            if (exhibition.Paintings.Contains(picture))
            {
                return $"Картина '{picture.Title}' находится в галерее '{exhibition.CurrentGallery.Name}' на выставке '{exhibition.Name}'.";
            }
        }

        foreach (var room in picture.CurrentGallery.Rooms)
        {
            if (room.Paintings.Contains(picture))
            {
                return $"Картина '{picture.Title}' находится в галерее '{picture.CurrentGallery.Name}' в комнате '{room.Name}'.";
            }
        }

        if (picture.CurrentGallery.Storage.Contains(picture))
        {
            throw new Exception("Картина находится в хранилище и не доступна для просмотра.");
        }

        throw new Exception("Картина не найдена.");
    }

}

