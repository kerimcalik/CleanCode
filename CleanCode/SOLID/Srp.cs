using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.GoodCode
{
    class Srp
    {
        public class User
        {
            long _userId;
            Address _address;
            string _name;
            string _surname;
        }

        public class Address
        {
            public int CityId { get; set; }
            public int countryId { get; set; }
            public string Street { get; set; }
        }

        public class LoginServices
        {
            public void Login(User user)
            {

            }

            public void Logout(User user)
            {

            }
        }

        public class AddressServices
        {
            public void ChangeAddress(Address address)
            {

            }
        }
    }
}

namespace CleanCode.SOLID.BadCode
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }

        public void Login(string userName, string password)
        {
            //logic code
        }

        public void Logout(string userName)
        {
            //logic
        }

        public void ChangeAddress(string address, string city)
        {

        }
    }
}
