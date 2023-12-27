public class Data
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public Data(int year)
    {
        Year = year;
    }

    public Data(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public Data(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public string GetDate()
    {
        return $"{Day}.{Month}.{Year}";
    }

    public int CompareTo(Data other)
    {
        if (this.Year != other.Year)
        {
            return this.Year.CompareTo(other.Year);
        }
        else if (this.Month != other.Month)
        {
            return this.Month.CompareTo(other.Month);
        }
        else
        {
            return this.Day.CompareTo(other.Day);
        }
    }
}

