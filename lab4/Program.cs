using System.Net;
using lab4;

string root = FileRoot.fileRoot;
char dirSep = Path.DirectorySeparatorChar;
string csvfile = root + dirSep + "data.csv";
string psvFile = root + dirSep + "data.psv";

List<Person> people = new List<Person>();

using(StreamReader sr = new StreamReader(csvfile))
{
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var info = line.Split(",");


        var fname = info[0];
        var lname = info[1];
        var sAddress = info[2];
        var city = info[3];
        var state = info[4];
        var pcode = info[5];
        Address address = new Address(sAddress, city, state, pcode);
        
        people.Add(new Person(fname,lname,address));

    }
}
people.Sort();
using (StreamWriter sw = new StreamWriter(psvfile))
{
    foreach (Person p in people)
    {
        // interpolated string
        string line = $"{p.FirstName}|{p.LastName}|{p.Address}";
        sw.WriteLine(line);
    }
}
