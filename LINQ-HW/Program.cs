// See https://aka.ms/new-console-template for more information


#region Q1

using LINQ_HW;

int[] numbersArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 34, 84, 67, 51, 24, 29, 37, -4, -7, -80, -35, -40, -75, -24 };

var query1 = from num in numbersArr
             where num < 0
             select num;

foreach (var item in query1)
{
    //Console.WriteLine(item);
}

var query12 = numbersArr.Where(delegate (int num)
{
    if (num < 0) return true;
    else return false;
});

foreach (var item in query12)
{
    //Console.WriteLine(item);
}

#endregion


#region Q2

var query2 = (from num in numbersArr
              where num % 2 == 1
              select num).OrderByDescending(n => n);

foreach (var item in query2)
{
    //Console.WriteLine(item);
}

var query22 = numbersArr.Where(n => n % 2 == 1).OrderByDescending(n => n);

foreach (var item in query22)
{
    //Console.WriteLine(item);
}

#endregion


#region Q3

var query3 = from num in numbersArr
             where num > 5 && num % 3 != 0
             select num * 3;

foreach (var item in query3)
{
    //Console.WriteLine(item);
}

var query32 = numbersArr.Where(n => n > 5 && n % 3 != 0).Select(n => n * 3);

foreach (var item in query32)
{
    //Console.WriteLine(item);
}

#endregion


#region Q4

string[] cities = new string[] { "london", "new york", "boston", "new jersey", "detroit", "new mexico", "paris" };

string[] newCities = Question42("new", cities);

foreach (var item in newCities)
{
    //Console.WriteLine(item);
}




static string[] Question4(string str, string[] cities)
{
    var query4 = (from city in cities
                  where city.Contains(str)
                  select city).ToArray();
    return query4;
}

static string[] Question42(string str, string[] cities)
{
    var query4 = cities.Where(c => c.Contains(str)).ToArray();
    return query4;
}

#endregion


#region Q5

newCities = Question52("new", cities);

foreach (var item in newCities)
{
    //Console.WriteLine(item);
}

static string[] Question5(string str, string[] cities)
{
    var query5 = (from city in cities
                  where !city.StartsWith(str)
                  select city).ToArray();
    return query5;
}

static string[] Question52(string str, string[] cities)
{
    var query5 = cities.Where(c => !c.StartsWith(str)).ToArray();
    return query5;
}

#endregion


#region Q6

string str = "new";
var query6 = (from city in cities
              where city.Contains(str)
              select city).First();

var query62 = cities.Where(city => city.Contains(str)).First();

//Console.WriteLine(query62);

#endregion


#region Q7

var query7 = (from city in cities
              orderby city
              select city).Take(3);

var query72 = cities.OrderBy(c => c).Take(3);

foreach (var item in query72)
{
    //Console.WriteLine(item);
}

#endregion

#region Q8

List<City> cities1= new List<City>();
cities1.Add(new City(1, "london",50000));
cities1.Add(new City(2, "new york", 20000));
cities1.Add(new City(3, "boston", 10000));
cities1.Add(new City(4, "new jersey", 45000));
cities1.Add(new City(5, "detroit", 35000));
cities1.Add(new City(6, "new mexico", 25000));
cities1.Add(new City(7, "paris", 70000));

var query8 = from city in cities1
             where city.NumberOfPopulation>25000
             select city;

var query82 = cities1.Where(c => c.NumberOfPopulation > 25000);

foreach (var item in query82)
{
    //Console.WriteLine(item.Name);
}

#endregion

#region Q9

var query9 = from city in cities1
             where city.NumberOfPopulation > 25000
             select city.Name;

var query92 = cities1.Where(c => c.NumberOfPopulation > 25000).Select(c => c.Name);

foreach (var item in query9)
{
    //Console.WriteLine(item);
}

#endregion

#region Q10

var query10 = from c in cities1
              select new { Name = c.Name, definition = c.NumberOfPopulation > 25000 ? Definition.city : Definition.town };

var query102 = cities1.Select(c => new { Name = c.Name, definition = c.NumberOfPopulation > 25000 ? Definition.city: Definition.town });

foreach (var item in query10)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.definition);
}

#endregion
