namespace testUnit
{
    [TestClass]
    public class GalleryTests
    {
        [TestMethod]
        public void AddPictureToStorage_PictureNotInAnotherGallery_AddsSuccessfully()
        {
            // Arrange
            var gallery = new Gallery();
            var picture = new Picture();

            // Act
            gallery.AddPictureToStorage(picture);

            // Assert
            Assert.IsTrue(gallery.Storage.Contains(picture));
            Assert.AreEqual(gallery, picture.CurrentGallery);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPictureToStorage_PictureInAnotherGallery_ThrowsException()
        {
            // Arrange
            var gallery1 = new Gallery();
            var gallery2 = new Gallery();
            var picture = new Picture();
            gallery1.AddPictureToStorage(picture);

            // Act
            gallery2.AddPictureToStorage(picture);
        }

        [TestMethod]
        public void Name()
        {
            var gallery = new Gallery();
            var expectedName = "Test Gallery";

            gallery.Name = expectedName;

            Assert.AreEqual(expectedName, gallery.Name);
        }

        [TestMethod]
        public void Address()
        {
            var gallery = new Gallery();
            var expectedName = "Test Gallery";

            gallery.Address = expectedName;

            Assert.AreEqual(expectedName, gallery.Address);
        }

        [TestMethod]
        public void Rooms()
        {
            // Arrange
            var gallery = new Gallery();
            var expectedRooms = new List<Room>();

            // Act
            gallery.Rooms = expectedRooms;

            // Assert
            CollectionAssert.AreEqual(expectedRooms, gallery.Rooms);
        }

        [TestMethod]
        public void Exhibitions()
        {
            // Arrange
            var gallery = new Gallery();
            var expectedExhibitions = new List<Exhibition>();

            // Act
            gallery.Exhibitions = expectedExhibitions;

            // Assert
            CollectionAssert.AreEqual(expectedExhibitions, gallery.Exhibitions);
        }

        [TestMethod]
        public void Storage()
        {
            // Arrange
            var gallery = new Gallery();
            var expectedStorage = new List<Picture>();

            // Act
            gallery.Storage = expectedStorage;

            // Assert
            CollectionAssert.AreEqual(expectedStorage, gallery.Storage);
        }

        [TestMethod]
        public void RequestPainting()
        {
            // Arrange
            Gallery gallery = new Gallery();
            Artist artist = new Artist(); // replace with actual Artist instance
            string title = "Test Title";
            string technique = "Test Technique";
            int size = 104;

            // Act
            var requestedPainting = gallery.RequestPainting(artist, title, technique, size);

            // Assert
            Assert.AreEqual(title, requestedPainting.Title);
            Assert.IsTrue(requestedPainting.Authors.Contains(artist));
            Assert.AreEqual(technique, requestedPainting.Technique);
            Assert.AreEqual(size, requestedPainting.Size);
        }

        [TestMethod]
        public void AddPictureToStorage()
        {
            // ����������
            var gallery = new Gallery();
            var picture = new Picture();

            // ��������
            gallery.AddPictureToStorage(picture);

            // ��������
            Assert.IsTrue(gallery.Storage.Contains(picture));
            Assert.AreEqual(gallery, picture.CurrentGallery);
        }

        [TestMethod]
        public void RemovePictureFromStorage()
        {
            // ����������
            var gallery = new Gallery();
            var picture = new Picture();
            gallery.Storage = new List<Picture> { picture };

            // ��������
            gallery.RemovePictureFromStorage(picture);

            // ��������
            Assert.IsFalse(gallery.Storage.Contains(picture));
            Assert.IsNull(picture.CurrentGallery);
        }

        [TestMethod]
        public void AddExhibition()
        {
            // ����������
            var gallery = new Gallery();
            var exhibition = new Exhibition();

            // ��������
            gallery.AddExhibition(exhibition);

            // ��������
            Assert.IsTrue(gallery.Exhibitions.Contains(exhibition));
            Assert.AreEqual(gallery, exhibition.CurrentGallery);
        }

        [TestMethod]
        public void RemoveExhibition()
        {
            // ����������
            var gallery = new Gallery();
            var exhibition = new Exhibition();
            gallery.Exhibitions = new List<Exhibition> { exhibition };

            // ��������
            gallery.RemoveExhibition(exhibition);

            // ��������
            Assert.IsFalse(gallery.Exhibitions.Contains(exhibition));
            Assert.IsNull(exhibition.CurrentGallery);
        }
    }

    [TestClass]
    public class ExhibitionTests
    {
        [TestMethod]
        public void Name()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedName = "�������� ��������";

            // ��������
            exhibition.Name = expectedName;

            // ��������
            Assert.AreEqual(expectedName, exhibition.Name);
        }

        [TestMethod]
        public void StartDate()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedStartDate = new Data(12, 12, 2012); // �������� �� �������� ��������� Data

            // ��������
            exhibition.StartDate = expectedStartDate;

            // ��������
            Assert.AreEqual(expectedStartDate, exhibition.StartDate);
        }

        [TestMethod]
        public void FinishDate()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedFinishDate = new Data(12, 12, 2012);

            // ��������
            exhibition.FinishDate = expectedFinishDate;

            // ��������
            Assert.AreEqual(expectedFinishDate, exhibition.FinishDate);
        }

        [TestMethod]
        public void Paintings()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedPaintings = new List<Picture>();

            // ��������
            exhibition.Paintings = expectedPaintings;

            // ��������
            CollectionAssert.AreEqual(expectedPaintings, exhibition.Paintings);
        }

        [TestMethod]
        public void Viewers()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedViewers = new List<Visitor>();

            // ��������
            exhibition.Viewers = expectedViewers;

            // ��������
            CollectionAssert.AreEqual(expectedViewers, exhibition.Viewers);
        }

        [TestMethod]
        public void Comments()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedComments = new List<Comment>();

            // ��������
            exhibition.Comments = expectedComments;

            // ��������
            CollectionAssert.AreEqual(expectedComments, exhibition.Comments);
        }

        [TestMethod]
        public void CurrentGallery()
        {
            // ����������
            var exhibition = new Exhibition();
            var expectedCurrentGallery = new Gallery();

            // ��������
            exhibition.CurrentGallery = expectedCurrentGallery;

            // ��������
            Assert.AreEqual(expectedCurrentGallery, exhibition.CurrentGallery);
        }

        //[TestMethod]
        //public void AddPicture()
        //{
        //    // ����������
        //    var gallery = new Gallery();
        //    var exhibition = new Exhibition() { CurrentGallery = gallery };
        //    var picture = new Picture() { CurrentGallery = gallery };

        //    // ��������
        //    exhibition.AddPicture(picture);

        //    // ��������
        //    Assert.IsTrue(exhibition.Paintings.Contains(picture));
        //}

        [TestMethod]
        public void RemovePicture()
        {
            // ����������
            var picture = new Picture();
            var exhibition = new Exhibition() { Paintings = new List<Picture> { picture } };

            // ��������
            exhibition.RemovePicture(picture);

            // ��������
            Assert.IsFalse(exhibition.Paintings.Contains(picture));
        }
    }


    [TestClass]
    public class CuratorTests
    {
        [TestMethod]
        public void Nationality()
        {
            // ����������
            var curator = new �urator();
            var expectedNationality = "�������� ��������������";

            // ��������
            curator.Nationality = expectedNationality;

            // ��������
            Assert.AreEqual(expectedNationality, curator.Nationality);
        }

        [TestMethod]
        public void Shows()
        {
            // ����������
            var curator = new �urator();
            var expectedShows = new List<Exhibition>();

            // ��������
            curator.Shows = expectedShows;

            // ��������
            CollectionAssert.AreEqual(expectedShows, curator.Shows);
        }

        [TestMethod]
        public void OrganizeExhibition()
        {
            // ����������
            var curator = new �urator();
            var name = "�������� ��������";
            var startDate = new Data(12, 12, 2012);
            var finishDate = new Data(12, 12, 2012);
            var paintings = new List<Picture>();

            // ��������
            curator.OrganizeExhibition(name, startDate, finishDate, paintings);

            // ��������
            var exhibition = curator.Shows[0];
            Assert.AreEqual(name, exhibition.Name);
            Assert.AreEqual(startDate, exhibition.StartDate);
            Assert.AreEqual(finishDate, exhibition.FinishDate);
            CollectionAssert.AreEqual(paintings, exhibition.Paintings);
        }

        [TestMethod]
        public void AddArtistPaintingsToExhibition()
        {
            // ����������
            var curator = new �urator();
            var artist = new Artist();
            var painting = new Picture();
            artist.Paintings = new List<Picture> { painting };
            var exhibition = new Exhibition();

            // ��������
            curator.AddArtistPaintingsToExhibition(artist, exhibition);

            // ��������
            Assert.IsTrue(exhibition.Paintings.Contains(painting));
        }
    }

    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void Day()
        {
            // ����������
            var data = new Data(1, 12, 12);
            var expectedDay = 1;
            // ��������
            data.Day = expectedDay;

            // ��������
            Assert.AreEqual(expectedDay, data.Day);
        }

        [TestMethod]
        public void Month()
        {
            // ����������
            var data = new Data(1, 12, 12);
            var expectedMonth = 12;
            // ��������
            data.Month = expectedMonth;

            // ��������
            Assert.AreEqual(expectedMonth, data.Month);
        }

        [TestMethod]
        public void Year()
        {
            // ����������
            var data = new Data(1, 12, 12);
            var expectedYear = 12;
            // ��������
            data.Month = expectedYear;

            // ��������
            Assert.AreEqual(expectedYear, data.Year);
        }

        [TestMethod]
        public void GetDate()
        {
            // ����������
            var data = new Data(1, 1, 2023);
            var expectedDate = "1.1.2023";

            // ��������
            var actualDate = data.GetDate();

            // ��������
            Assert.AreEqual(expectedDate, actualDate);
        }

        [TestMethod]
        public void CompareTo()
        {
            // ����������
            var data1 = new Data(1, 1, 2011);
            var data2 = new Data(1, 2, 2011);
            var expectedComparison = -1;

            // ��������
            var actualComparison = data1.CompareTo(data2);

            // ��������
            Assert.AreEqual(expectedComparison, actualComparison);
        }

    }


    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void Name()
        {
            // ����������
            var room = new Room();
            var expectedName = "�������� �������";

            // ��������
            room.Name = expectedName;

            // ��������
            Assert.AreEqual(expectedName, room.Name);
        }

        [TestMethod]
        public void Size()
        {
            // ����������
            var room = new Room();
            var expectedSize = 100;

            // ��������
            room.Size = expectedSize;

            // ��������
            Assert.AreEqual(expectedSize, room.Size);
        }

        [TestMethod]
        public void Paintings()
        {
            // ����������
            var room = new Room();
            var expectedPaintings = new List<Picture>();

            // ��������
            room.Paintings = expectedPaintings;

            // ��������
            CollectionAssert.AreEqual(expectedPaintings, room.Paintings);
        }

        [TestMethod]
        public void Gallery()
        {
            // ����������
            var room = new Room();
            var expectedGallery = new Gallery();

            // ��������
            room.Gallery = expectedGallery;

            // ��������
            Assert.AreEqual(expectedGallery, room.Gallery);
        }

        [TestMethod]
        public void AddPicture()
        {
            // ����������
            var room = new Room();
            var gallery = new Gallery();
            room.Gallery = gallery;
            var picture = new Picture();
            picture.CurrentGallery = gallery;

            // ��������
            room.AddPicture(picture);

            // ��������
            Assert.IsTrue(room.Paintings.Contains(picture));
        }

        [TestMethod]
        public void RemovePicture()
        {
            // ����������
            var room = new Room();
            var picture = new Picture();
            room.Paintings = new List<Picture> { picture };

            // ��������
            room.RemovePicture(picture);

            // ��������
            Assert.IsFalse(room.Paintings.Contains(picture));
        }
    }

    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void Name()
        {
            // ����������
            var human = new Human();
            var expectedName = "�������� ���";

            // ��������
            human.Name = expectedName;

            // ��������
            Assert.AreEqual(expectedName, human.Name);
        }

        [TestMethod]
        public void Age()
        {
            // ����������
            var human = new Human();
            var expectedAge = 30;

            // ��������
            human.Age = expectedAge;

            // ��������
            Assert.AreEqual(expectedAge, human.Age);
        }
    }

    [TestClass]
    public class AppraiserTests
    {
        [TestMethod]
        public void ExperienceYears()
        {
            // ����������
            var appraiser = new Appraiser();
            var expectedExperienceYears = 10;

            // ��������
            appraiser.ExperienceYears = expectedExperienceYears;

            // ��������
            Assert.AreEqual(expectedExperienceYears, appraiser.ExperienceYears);
        }

        [TestMethod]
        public void AppraisePainting()
        {
            // ����������
            var appraiser = new Appraiser() { ExperienceYears = 10 };
            var painting = new Picture() { Year = new Data(2023)};
            var expectedValue = 20230;

            // ��������
            var actualValue = appraiser.AppraisePainting(painting);

            // ��������
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void IsOriginalMethod_Original()
        {
            // ����������
            var appraiser = new Appraiser();
            var painting1 = new Picture() { Title = "�������� �������", Year = new Data(2023)};
            var allPaintings = new List<Picture>() { painting1 };

            // ��������
            var isOriginal = appraiser.IsOriginal(painting1, allPaintings);

            // ��������
            Assert.IsTrue(isOriginal);
        }

        [TestMethod]
        public void IsOriginalMethod_NotOriginal()
        {
            // ����������
            var appraiser = new Appraiser();
            var painting1 = new Picture() { Title = "�������� �������", Year = new Data(2023)};
            var painting2 = new Picture() { Title = "�������� �������", Year = new Data(2022)};
            var allPaintings = new List<Picture>() { painting1, painting2 };

            // ��������
            var isOriginal = appraiser.IsOriginal(painting1, allPaintings);

            // ��������
            Assert.IsFalse(isOriginal);
        }
    }

    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        public void Shows()
        {
            // ����������
            var visitor = new Visitor();
            var expectedShows = new List<Exhibition>();

            // ��������
            visitor.Shows = expectedShows;

            // ��������
            CollectionAssert.AreEqual(expectedShows, visitor.Shows);
        }

        [TestMethod]
        public void LeaveComment()
        {
            // ����������
            var visitor = new Visitor();
            var exhibition = new Exhibition();
            visitor.Shows = new List<Exhibition> { exhibition };
            var text = "�������� �����������";
            var date = new Data(1, 1, 2023);

            // ��������
            visitor.LeaveComment(exhibition, text, date);

            // ��������
            Assert.IsTrue(exhibition.Comments.Any(c => c.Text == text && c.Date == date && c.Author == visitor));
        }

        [TestMethod]
        public void VisitExhibition()
        {
            // ����������
            var visitor = new Visitor();
            var exhibition = new Exhibition();

            // ��������
            visitor.VisitExhibition(exhibition);

            // ��������
            Assert.IsTrue(visitor.Shows.Contains(exhibition));
        }

        [TestMethod]
        public void FindPicture()
        {
            // ����������
            var visitor = new Visitor();
            var gallery = new Gallery();
            var exhibition = new Exhibition() { CurrentGallery = gallery };
            var picture = new Picture() { Title = "�������� �������", CurrentGallery = gallery };
            exhibition.Paintings = new List<Picture> { picture };
            visitor.Shows = new List<Exhibition> { exhibition };

            // ��������
            var result = visitor.FindPicture(picture);

            // ��������
            Assert.AreEqual($"������� '{picture.Title}' ��������� � ������� '{exhibition.CurrentGallery.Name}' �� �������� '{exhibition.Name}'.", result);
        }
    }
}


    