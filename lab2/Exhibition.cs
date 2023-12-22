
public class Exhibition
{
    public string Name { get; set; }
    public Data StartDate { get; set; }
    public Data FinishDate { get; set; }
    public List<Picture> Paintings { get; set; }
    public List<Visitor> Viewers { get; set; }
    public List<Comment> Comments { get; set; }
    public Gallery CurrentGallery { get; set; }

    public void AddPicture(Picture picture)
    {
        if (picture.CurrentGallery != null && picture.CurrentGallery != this.CurrentGallery)
        {
            picture.CurrentGallery.Storage.Remove(picture);
            picture.CurrentGallery = this.CurrentGallery;
            Paintings.Add(picture);
        }
        else if (picture.CurrentGallery == this.CurrentGallery)
        {
            Paintings.Add(picture);
        }
        else
        {
            throw new Exception("Картина не находится в хранилище.");
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
            throw new Exception("Картина не участвует в этой выставке.");
        }
    }

}

