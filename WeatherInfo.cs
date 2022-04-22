using System.Collections.Generic;

namespace Calendar
{
    /**
    * przechowuje informacje o pogodzie pobrane z zewnętrznego API (Open Weather)
    **/
    class WeatherInfo
    {
        /**
        * współrzędne geograficzne miasta (mniej istotne)
        **/
        public class coord
        {
            /**
            * długość geograficzna
            **/
            public double lon { get; set; }
            /**
            * szerokość geograficzna
            **/
            public double lat { get; set; }
        }

        /**
        * główne informacje
        **/
        public class weather
        {
            /**
            * ogólne warunki
            **/
            public string? main { get; set; }

            /**
            * szczegółowe warunki
            **/
            public string? description { get; set; }

            /**
            * kod ikony
            **/
            public string? icon { get; set; }
        }

        /**
        * main - ogólne informacje
        **/
        public class main
        {
            /**
            * temp - temperatura
            **/
            public double temp { get; set; }

            /**
            * pressure - ciśnienie
            **/
            public double pressure { get; set; }
            /**
            * humidity - wilgotność
            **/
            public double humidity { get; set; }
        }

        /**
        * informacje o wietrze
        **/
        public class wind
        {
            /**
            * speed - prędkość wiatru w m/s
            **/
            public double speed { get; set; }
        }

        /**
        * informacje o wschodzie i zachodzie słońca
        **/
        public class sys
        {
            /**
            * wschód słońca (liczba sekund od 1 stycznia 1970 00:00:00)
            **/
            public long sunrise { get; set; }

            /**
            * zachód słońca (liczba sekund od 1 stycznia 1970 00:00:00)
            **/
            public long sunset { get; set; }
        }

        /**
        * klasa zawierająca w sobie wszystkie informacje
        **/
        public class root
        {
            /**
            * współrzędne geograficzne
            **/
            public coord? coord { get; set; }

            /**
            * warunki pogodowe
            **/
            public List<weather>? weather { get; set; }

            /**
            * główne informacje
            **/
            public main? main { get; set; }

            /**
            *  wiatr
            **/
            public wind? wind { get; set; }

            /**
            * wschód i zachód słońca
            **/
            public sys? sys { get; set; }
        }
    }
}