public class Room
{
    public string Name { get; set; }
    public int Size { get; set; }
    public List<Picture> Paintings { get; set; }
    public Gallery Gallery { get; set; }

    public void AddPicture(Picture picture)
    {
        if (picture.CurrentGallery == this.Gallery)
        {
            Paintings.Add(picture);
        }
        else
        {
            throw new Exception("Картина не находится в этой галерее.");
        }
    }

    public void RemovePicture(Picture picture)
    {
        if (Paintings.Contains(picture))
        {
            Paintings.Remove(picture);
        }
        else
        {
            throw new Exception("Картина не находится в этой комнате.");
        }
    }
}

