using System;
namespace lab4
{
    public class Person : IComparable
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }

        public Person(string firstName, string lastName, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;

        }
        public Person()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            

        }
       
        public int CompareTo(object? obj )
        {
            Person p = (Person)obj;
            return String.Compare(this.LastName, p.LastName);
        }

        public override string ToString()
        {
            return
                $"{FirstName}|{LastName}|{Address}";
        }
    }
}

