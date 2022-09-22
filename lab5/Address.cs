using System;
namespace lab4
{
    public class Address
    {
        public string StreetAddress { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string PostalCode { get; init; }

        public Address(string StreetAddress, string City, string State, string PostalCode)
        {
            this.StreetAddress = StreetAddress;
            this.City = City;
            this.State = State;
            this.PostalCode = PostalCode;
        }
        public Address()
        {
            StreetAddress = String.Empty;
            City = String.Empty;
            State = String.Empty;
            PostalCode = String.Empty;
        }
        public override string ToString()
        {
            return
                $"{StreetAddress}|{City}|{State}|{PostalCode}";
        }
    }
}

