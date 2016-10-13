using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            City Denver = new Cities.City("Denver", "Colorado", new LatLng(104.9903, 39.7392));
            Neighborhood LowDow = new Neighborhood("LowDow", Denver);
            Denver.burroughs.Add(LowDow);
            Restaurant Snooze = new Restaurant("Snooze", new Address(new LatLng(104.0703, 39.2192), "111 Union", 80220, "Colorado", Denver), Restaurant.Category.American, "www.Snooze.com");
            Denver.restaurants.Add(Snooze);
            LowDow.restaurants.Add(Snooze);
            Restaurant Merkantile = new Restaurant("Merkantile", new Address(new LatLng(104.00903, 39.0992), "222 Union", 80220, "Colorado", Denver ), Restaurant.Category.American, "www.Merkantile.com");
            Denver.restaurants.Add(Merkantile);
            LowDow.restaurants.Add(Merkantile);
            Neighborhood CapHill = new Neighborhood("CapHill", Denver);
            Denver.burroughs.Add(CapHill);
            Restaurant CityOCity = new Restaurant("CityOCity", new Address(new LatLng(104.93403, 39.8392), "333 14th st", 82020, "Colorado", Denver), Restaurant.Category.American, "www.CityOCity.com");
            Denver.restaurants.Add(CityOCity);
            LowDow.restaurants.Add(CityOCity);
            Restaurant CheekyMonk = new Restaurant("CheekyMonk", new Address(new LatLng(104.4903, 39.7192), "444 13th st", 82020, "Colorado", Denver), Restaurant.Category.German, "www.CheekyMonk.com");
            Denver.restaurants.Add(CheekyMonk);
            LowDow.restaurants.Add(CheekyMonk);
            Neighborhood CherryCreek = new Neighborhood("CherryCreek", Denver);
            Denver.burroughs.Add(CherryCreek);
            Restaurant Merakesh = new Restaurant("Marakesh", new Address(new LatLng(104.9933, 39.7302), "555 Colorado blvd", 80212, "Colorado", Denver), Restaurant.Category.Other, "www.marakesh.com");
            Denver.restaurants.Add(Merakesh);
            LowDow.restaurants.Add(Merakesh);
            Restaurant Paxtis = new Restaurant("Paxtis", new Address(new LatLng(104.1903, 39.7892), "777 6th Ave", 80212, "Colorado", Denver), Restaurant.Category.Italian, "www.Paxtis.com");
            Denver.restaurants.Add(Paxtis);
            LowDow.restaurants.Add(Paxtis);
            Neighborhood Colfax = new Neighborhood("Colfax", Denver);
            Denver.burroughs.Add(Colfax);
            Restaurant FatSullys = new Restaurant("FatSullys", new Address(new LatLng(104.9203, 39.7592), "888 Colfax", 80128, "Colorado", Denver), Restaurant.Category.American, "www.Fatsullys.com");
            Denver.restaurants.Add(FatSullys);
            LowDow.restaurants.Add(FatSullys);
            Restaurant Pinches = new Restaurant("Pinches", new Address(new LatLng(104.8903, 39.7992), "999 Colfax", 80128, "Colorado", Denver), Restaurant.Category.Mexican, "www.tequilla&wiskey.com");
            Denver.restaurants.Add(Pinches);
            LowDow.restaurants.Add(Pinches);
            Neighborhood Highland = new Neighborhood("Highland", Denver);
            Denver.burroughs.Add(Highland);
            Restaurant Uncle = new Restaurant("Uncle", new Address(new LatLng(104.9703, 39.7362), "1010 22nd", 80127, "Colorado", Denver), Restaurant.Category.Japanese, "www.Uncle.com");
            Denver.restaurants.Add(Uncle);
            LowDow.restaurants.Add(Uncle);
            Restaurant RootDown = new Restaurant("Root Down", new Address(new LatLng(102.9903, 40.7392), "1122 Zuni st", 80127, "Colorado", Denver), Restaurant.Category.Other, "www.RootDown.com");
            Denver.restaurants.Add(RootDown);
            LowDow.restaurants.Add(RootDown);





        }

    }
    public class City
    {
        string name;
        string state;
        LatLng coords;
        public List<Neighborhood> burroughs;
        public List<Restaurant> restaurants;
        public List<City> neighboringCities;
        public City(String name, String state, LatLng location)
        {
            this.name = name;
            this.state = state;
            coords = location;
        }

    }
    public class Neighborhood
    {
        string name;
        City city;
        public List<Restaurant> restaurants;
        public Neighborhood(string name, City city)
        {
            this.city = city;
            this.name = name;
        }

    }

    
    public class Restaurant
    {
        public enum Category
        {
            Italian,
            American,
            Thai,
            German,
            French,
            English,
            Mexican,
            Spanish,
            Chinese,
            Korean,
            Japanese,
            Other
        }
        Address address;
        string name;
        Category type;
        string websiteUrl;
        public Restaurant(string name, Address address, Category type, string websiteUrl)
        {
            this.name = name;
            this.address = address;
            this.type = type;
            this.websiteUrl = websiteUrl;
        }
        
    }
    public class LatLng
    {
        double Lat;
        double Lng;
        public LatLng(double Lat, double Lng)
        {
            this.Lng = Lng;
            this.Lat = Lat;
        }
    }

    public class Address
    {
        LatLng latlng;
        string streetAddress;
        int zip;
        string state;
        City city;
        public Address(LatLng latlng, string streetAddress, int zip, string state, City city)
        {
            this.latlng = latlng;
            this.streetAddress = streetAddress;
            this.state = state;
            this.city = city;
            this.zip = zip; 
        }
    }







    // the stuff I'm saving that I dont know why I need it

    //public class save        {
    //    City Houston = new City();
    //    Neighborhood Montrose = new Neighborhood();
    //    Restaurant HM1 = new Restaurant();
    //    Restaurant HM2 = new Restaurant();
    //    Restaurant HM3 = new Restaurant();
    //    Restaurant HM4 = new Restaurant();
    //    Restaurant HM5 = new Restaurant();
    //    Restaurant HM6 = new Restaurant();
    //    Restaurant HM7 = new Restaurant();
    //    Restaurant HM8 = new Restaurant();
    //    Restaurant HM9 = new Restaurant();
    //    Restaurant HM10 = new Restaurant();
    //    Neighborhood Hieghts = new Neighborhood();
    //    Restaurant HH1 = new Restaurant();
    //    Restaurant HH2 = new Restaurant();
    //    Restaurant HH3 = new Restaurant();
    //    Restaurant HH4 = new Restaurant();
    //    Restaurant HH5 = new Restaurant();
    //    Restaurant HH6 = new Restaurant();
    //    Restaurant HH7 = new Restaurant();
    //    Restaurant HH8 = new Restaurant();
    //    Restaurant HH9 = new Restaurant();
    //    Restaurant HH10 = new Restaurant();
    //    Neighborhood Sugarland = new Neighborhood();
    //    Restaurant HS1 = new Restaurant();
    //    Restaurant HS2 = new Restaurant();
    //    Restaurant HS3 = new Restaurant();
    //    Restaurant HS4 = new Restaurant();
    //    Restaurant HS5 = new Restaurant();
    //    Restaurant HS6 = new Restaurant();
    //    Restaurant HS7 = new Restaurant();
    //    Restaurant HS8 = new Restaurant();
    //    Restaurant HS9 = new Restaurant();
    //    Restaurant HS10 = new Restaurant();
    //    Neighborhood Eado = new Neighborhood();
    //    Restaurant HE1 = new Restaurant();
    //    Restaurant HE2 = new Restaurant();
    //    Restaurant HE3 = new Restaurant();
    //    Restaurant HE4 = new Restaurant();
    //    Restaurant HE5 = new Restaurant();
    //    Restaurant HE6 = new Restaurant();
    //    Restaurant HE7 = new Restaurant();
    //    Restaurant HE8 = new Restaurant();
    //    Restaurant HE9 = new Restaurant();
    //    Restaurant HE10 = new Restaurant();
    //    Neighborhood Midtown = new Neighborhood();
    //    Restaurant HMD1 = new Restaurant();
    //    Restaurant HMD2 = new Restaurant();
    //    Restaurant HMD3 = new Restaurant();
    //    Restaurant HMD4 = new Restaurant();
    //    Restaurant HMD5 = new Restaurant();
    //    Restaurant HMD6 = new Restaurant();
    //    Restaurant HMD7 = new Restaurant();
    //    Restaurant HMD8 = new Restaurant();
    //    Restaurant HMD9 = new Restaurant();
    //    Restaurant HMd10 = new Restaurant();

    //City Denver = new City();
    //Neighborhood fivePoints = new Neighborhood();
    //Restaurant r1 = new Restaurant();
    //Restaurant r2 = new Restaurant();
    //Restaurant r3 = new Restaurant();
    //Restaurant r4 = new Restaurant();
    //Restaurant r5 = new Restaurant();
    //Restaurant r6 = new Restaurant();
    //Restaurant r7 = new Restaurant();
    //Restaurant r8 = new Restaurant();
    //Restaurant r9 = new Restaurant();
    //Restaurant r10 = new Restaurant();
    //Neighborhood LowDow = new Neighborhood();
    //Restaurant r11 = new Restaurant();
    //Restaurant r12 = new Restaurant();
    //Restaurant r13 = new Restaurant();
    //Restaurant r14 = new Restaurant();
    //Restaurant r15 = new Restaurant();
    //Restaurant r16 = new Restaurant();
    //Restaurant r17 = new Restaurant();
    //Restaurant DL8 = new Restaurant();
    //Restaurant DL9 = new Restaurant();
    //Restaurant DL10 = new Restaurant();
    //Neighborhood TechCenter = new Neighborhood();
    //Restaurant DT1 = new Restaurant();
    //Restaurant DT2 = new Restaurant();
    //Restaurant DT3 = new Restaurant();
    //Restaurant DT4 = new Restaurant();
    //Restaurant DT5 = new Restaurant();
    //Restaurant DT6 = new Restaurant();
    //Restaurant DT7 = new Restaurant();
    //Restaurant DT8 = new Restaurant();
    //Restaurant DT9 = new Restaurant();
    //Restaurant DT10 = new Restaurant();
    //Neighborhood Highland = new Neighborhood();
    //Restaurant DH1 = new Restaurant();
    //Restaurant DH2 = new Restaurant();
    //Restaurant DH3 = new Restaurant();
    //Restaurant DH4 = new Restaurant();
    //Restaurant DH5 = new Restaurant();
    //Restaurant DH6 = new Restaurant();
    //Restaurant DH7 = new Restaurant();
    //Restaurant DH8 = new Restaurant();
    //Restaurant DH9 = new Restaurant();
    //Restaurant DH10 = new Restaurant();
    //Neighborhood CapitalHill = new Neighborhood();
    //Restaurant DC1 = new Restaurant();
    //Restaurant DC2 = new Restaurant();
    //Restaurant DC3 = new Restaurant();
    //Restaurant DC4 = new Restaurant();
    //Restaurant DC5 = new Restaurant();
    //Restaurant DC6 = new Restaurant();
    //Restaurant DC7 = new Restaurant();
    //Restaurant DC8 = new Restaurant();
    //Restaurant DC9 = new Restaurant();
    //Restaurant DC10 = new Restaurant();
    //}



}

