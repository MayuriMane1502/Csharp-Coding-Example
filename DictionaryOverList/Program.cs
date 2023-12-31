﻿using System;
using System.Collections.Generic;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital ="Canberra"};
            Country country2 = new Country() { Code= "IND", Name ="India", Capital= "New delhi"};
            Country country3 = new Country() { Code = "USA", Name = "UnitedState", Capital="washington D.C" };
            Country country4 = new Country() { Code="CAN", Name="Canada", Capital="Ottawa"};
            Country country5 = new Country() { Code= "GBR", Name= "United Kingdom", Capital="London"};

            /*List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5); */

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            string strUserChoice = string.Empty;
            do
            {

                Console.WriteLine("Please enter the country code: ");
                string strCountryCode = Console.ReadLine().ToUpper();

                // Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode]: null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");

                }
                else
                {
                    Console.WriteLine("Name= {0}, Capital= {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {

                    Console.WriteLine("You want to continue?- YES/NO");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Code { get; set; }
    }
}