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
            // Подготовка
            var gallery = new Gallery();
            var picture = new Picture();

            // Действие
            gallery.AddPictureToStorage(picture);

            // Проверка
            Assert.IsTrue(gallery.Storage.Contains(picture));
            Assert.AreEqual(gallery, picture.CurrentGallery);
        }

        [TestMethod]
        public void RemovePictureFromStorage()
        {
            // Подготовка
            var gallery = new Gallery();
            var picture = new Picture();
            gallery.Storage = new List<Picture> { picture };

            // Действие
            gallery.RemovePictureFromStorage(picture);

            // Проверка
            Assert.IsFalse(gallery.Storage.Contains(picture));
            Assert.IsNull(picture.CurrentGallery);
        }

        [TestMethod]
        public void AddExhibition()
        {
            // Подготовка
            var gallery = new Gallery();
            var exhibition = new Exhibition();

            // Действие
            gallery.AddExhibition(exhibition);

            // Проверка
            Assert.IsTrue(gallery.Exhibitions.Contains(exhibition));
            Assert.AreEqual(gallery, exhibition.CurrentGallery);
        }

        [TestMethod]
        public void RemoveExhibition()
        {
            // Подготовка
            var gallery = new Gallery();
            var exhibition = new Exhibition();
            gallery.Exhibitions = new List<Exhibition> { exhibition };

            // Действие
            gallery.RemoveExhibition(exhibition);

            // Проверка
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
            // Подготовка
            var exhibition = new Exhibition();
            var expectedName = "Тестовая выставка";

            // Действие
            exhibition.Name = expectedName;

            // Проверка
            Assert.AreEqual(expectedName, exhibition.Name);
        }

        [TestMethod]
        public void StartDate()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedStartDate = new Data(12, 12, 2012); // замените на реальный экземпляр Data

            // Действие
            exhibition.StartDate = expectedStartDate;

            // Проверка
            Assert.AreEqual(expectedStartDate, exhibition.StartDate);
        }

        [TestMethod]
        public void FinishDate()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedFinishDate = new Data(12, 12, 2012);

            // Действие
            exhibition.FinishDate = expectedFinishDate;

            // Проверка
            Assert.AreEqual(expectedFinishDate, exhibition.FinishDate);
        }

        [TestMethod]
        public void Paintings()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedPaintings = new List<Picture>();

            // Действие
            exhibition.Paintings = expectedPaintings;

            // Проверка
            CollectionAssert.AreEqual(expectedPaintings, exhibition.Paintings);
        }

        [TestMethod]
        public void Viewers()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedViewers = new List<Visitor>();

            // Действие
            exhibition.Viewers = expectedViewers;

            // Проверка
            CollectionAssert.AreEqual(expectedViewers, exhibition.Viewers);
        }

        [TestMethod]
        public void Comments()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedComments = new List<Comment>();

            // Действие
            exhibition.Comments = expectedComments;

            // Проверка
            CollectionAssert.AreEqual(expectedComments, exhibition.Comments);
        }

        [TestMethod]
        public void CurrentGallery()
        {
            // Подготовка
            var exhibition = new Exhibition();
            var expectedCurrentGallery = new Gallery();

            // Действие
            exhibition.CurrentGallery = expectedCurrentGallery;

            // Проверка
            Assert.AreEqual(expectedCurrentGallery, exhibition.CurrentGallery);
        }

        //[TestMethod]
        //public void AddPicture()
        //{
        //    // Подготовка
        //    var gallery = new Gallery();
        //    var exhibition = new Exhibition() { CurrentGallery = gallery };
        //    var picture = new Picture() { CurrentGallery = gallery };

        //    // Действие
        //    exhibition.AddPicture(picture);

        //    // Проверка
        //    Assert.IsTrue(exhibition.Paintings.Contains(picture));
        //}

        [TestMethod]
        public void RemovePicture()
        {
            // Подготовка
            var picture = new Picture();
            var exhibition = new Exhibition() { Paintings = new List<Picture> { picture } };

            // Действие
            exhibition.RemovePicture(picture);

            // Проверка
            Assert.IsFalse(exhibition.Paintings.Contains(picture));
        }
    }


    [TestClass]
    public class CuratorTests
    {
        [TestMethod]
        public void Nationality()
        {
            // Подготовка
            var curator = new Сurator();
            var expectedNationality = "Тестовая национальность";

            // Действие
            curator.Nationality = expectedNationality;

            // Проверка
            Assert.AreEqual(expectedNationality, curator.Nationality);
        }

        [TestMethod]
        public void Shows()
        {
            // Подготовка
            var curator = new Сurator();
            var expectedShows = new List<Exhibition>();

            // Действие
            curator.Shows = expectedShows;

            // Проверка
            CollectionAssert.AreEqual(expectedShows, curator.Shows);
        }

        [TestMethod]
        public void OrganizeExhibition()
        {
            // Подготовка
            var curator = new Сurator();
            var name = "Тестовая выставка";
            var startDate = new Data(12, 12, 2012);
            var finishDate = new Data(12, 12, 2012);
            var paintings = new List<Picture>();

            // Действие
            curator.OrganizeExhibition(name, startDate, finishDate, paintings);

            // Проверка
            var exhibition = curator.Shows[0];
            Assert.AreEqual(name, exhibition.Name);
            Assert.AreEqual(startDate, exhibition.StartDate);
            Assert.AreEqual(finishDate, exhibition.FinishDate);
            CollectionAssert.AreEqual(paintings, exhibition.Paintings);
        }

        [TestMethod]
        public void AddArtistPaintingsToExhibition()
        {
            // Подготовка
            var curator = new Сurator();
            var artist = new Artist();
            var painting = new Picture();
            artist.Paintings = new List<Picture> { painting };
            var exhibition = new Exhibition();

            // Действие
            curator.AddArtistPaintingsToExhibition(artist, exhibition);

            // Проверка
            Assert.IsTrue(exhibition.Paintings.Contains(painting));
        }
    }

    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void Day()
        {
            // Подготовка
            var data = new Data(1, 12, 12);
            var expectedDay = 1;
            // Действие
            data.Day = expectedDay;

            // Проверка
            Assert.AreEqual(expectedDay, data.Day);
        }

        [TestMethod]
        public void Month()
        {
            // Подготовка
            var data = new Data(1, 12, 12);
            var expectedMonth = 12;
            // Действие
            data.Month = expectedMonth;

            // Проверка
            Assert.AreEqual(expectedMonth, data.Month);
        }

        [TestMethod]
        public void Year()
        {
            // Подготовка
            var data = new Data(1, 12, 12);
            var expectedYear = 12;
            // Действие
            data.Month = expectedYear;

            // Проверка
            Assert.AreEqual(expectedYear, data.Year);
        }

        [TestMethod]
        public void GetDate()
        {
            // Подготовка
            var data = new Data(1, 1, 2023);
            var expectedDate = "1.1.2023";

            // Действие
            var actualDate = data.GetDate();

            // Проверка
            Assert.AreEqual(expectedDate, actualDate);
        }

        [TestMethod]
        public void CompareTo()
        {
            // Подготовка
            var data1 = new Data(1, 1, 2011);
            var data2 = new Data(1, 2, 2011);
            var expectedComparison = -1;

            // Действие
            var actualComparison = data1.CompareTo(data2);

            // Проверка
            Assert.AreEqual(expectedComparison, actualComparison);
        }

    }


    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void Name()
        {
            // Подготовка
            var room = new Room();
            var expectedName = "Тестовая комната";

            // Действие
            room.Name = expectedName;

            // Проверка
            Assert.AreEqual(expectedName, room.Name);
        }

        [TestMethod]
        public void Size()
        {
            // Подготовка
            var room = new Room();
            var expectedSize = 100;

            // Действие
            room.Size = expectedSize;

            // Проверка
            Assert.AreEqual(expectedSize, room.Size);
        }

        [TestMethod]
        public void Paintings()
        {
            // Подготовка
            var room = new Room();
            var expectedPaintings = new List<Picture>();

            // Действие
            room.Paintings = expectedPaintings;

            // Проверка
            CollectionAssert.AreEqual(expectedPaintings, room.Paintings);
        }

        [TestMethod]
        public void Gallery()
        {
            // Подготовка
            var room = new Room();
            var expectedGallery = new Gallery();

            // Действие
            room.Gallery = expectedGallery;

            // Проверка
            Assert.AreEqual(expectedGallery, room.Gallery);
        }

        [TestMethod]
        public void AddPicture()
        {
            // Подготовка
            var room = new Room();
            var gallery = new Gallery();
            room.Gallery = gallery;
            var picture = new Picture();
            picture.CurrentGallery = gallery;

            // Действие
            room.AddPicture(picture);

            // Проверка
            Assert.IsTrue(room.Paintings.Contains(picture));
        }

        [TestMethod]
        public void RemovePicture()
        {
            // Подготовка
            var room = new Room();
            var picture = new Picture();
            room.Paintings = new List<Picture> { picture };

            // Действие
            room.RemovePicture(picture);

            // Проверка
            Assert.IsFalse(room.Paintings.Contains(picture));
        }
    }

    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void Name()
        {
            // Подготовка
            var human = new Human();
            var expectedName = "Тестовое имя";

            // Действие
            human.Name = expectedName;

            // Проверка
            Assert.AreEqual(expectedName, human.Name);
        }

        [TestMethod]
        public void Age()
        {
            // Подготовка
            var human = new Human();
            var expectedAge = 30;

            // Действие
            human.Age = expectedAge;

            // Проверка
            Assert.AreEqual(expectedAge, human.Age);
        }
    }

    [TestClass]
    public class AppraiserTests
    {
        [TestMethod]
        public void ExperienceYears()
        {
            // Подготовка
            var appraiser = new Appraiser();
            var expectedExperienceYears = 10;

            // Действие
            appraiser.ExperienceYears = expectedExperienceYears;

            // Проверка
            Assert.AreEqual(expectedExperienceYears, appraiser.ExperienceYears);
        }

        [TestMethod]
        public void AppraisePainting()
        {
            // Подготовка
            var appraiser = new Appraiser() { ExperienceYears = 10 };
            var painting = new Picture() { Year = new Data(2023)};
            var expectedValue = 20230;

            // Действие
            var actualValue = appraiser.AppraisePainting(painting);

            // Проверка
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void IsOriginalMethod_Original()
        {
            // Подготовка
            var appraiser = new Appraiser();
            var painting1 = new Picture() { Title = "Тестовая картина", Year = new Data(2023)};
            var allPaintings = new List<Picture>() { painting1 };

            // Действие
            var isOriginal = appraiser.IsOriginal(painting1, allPaintings);

            // Проверка
            Assert.IsTrue(isOriginal);
        }

        [TestMethod]
        public void IsOriginalMethod_NotOriginal()
        {
            // Подготовка
            var appraiser = new Appraiser();
            var painting1 = new Picture() { Title = "Тестовая картина", Year = new Data(2023)};
            var painting2 = new Picture() { Title = "Тестовая картина", Year = new Data(2022)};
            var allPaintings = new List<Picture>() { painting1, painting2 };

            // Действие
            var isOriginal = appraiser.IsOriginal(painting1, allPaintings);

            // Проверка
            Assert.IsFalse(isOriginal);
        }
    }

    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        public void Shows()
        {
            // Подготовка
            var visitor = new Visitor();
            var expectedShows = new List<Exhibition>();

            // Действие
            visitor.Shows = expectedShows;

            // Проверка
            CollectionAssert.AreEqual(expectedShows, visitor.Shows);
        }

        [TestMethod]
        public void LeaveComment()
        {
            // Подготовка
            var visitor = new Visitor();
            var exhibition = new Exhibition();
            visitor.Shows = new List<Exhibition> { exhibition };
            var text = "Тестовый комментарий";
            var date = new Data(1, 1, 2023);

            // Действие
            visitor.LeaveComment(exhibition, text, date);

            // Проверка
            Assert.IsTrue(exhibition.Comments.Any(c => c.Text == text && c.Date == date && c.Author == visitor));
        }

        [TestMethod]
        public void VisitExhibition()
        {
            // Подготовка
            var visitor = new Visitor();
            var exhibition = new Exhibition();

            // Действие
            visitor.VisitExhibition(exhibition);

            // Проверка
            Assert.IsTrue(visitor.Shows.Contains(exhibition));
        }

        [TestMethod]
        public void FindPicture()
        {
            // Подготовка
            var visitor = new Visitor();
            var gallery = new Gallery();
            var exhibition = new Exhibition() { CurrentGallery = gallery };
            var picture = new Picture() { Title = "Тестовая картина", CurrentGallery = gallery };
            exhibition.Paintings = new List<Picture> { picture };
            visitor.Shows = new List<Exhibition> { exhibition };

            // Действие
            var result = visitor.FindPicture(picture);

            // Проверка
            Assert.AreEqual($"Картина '{picture.Title}' находится в галерее '{exhibition.CurrentGallery.Name}' на выставке '{exhibition.Name}'.", result);
        }
    }
}


    