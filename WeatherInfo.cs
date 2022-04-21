using System.Collections.Generic;

namespace Calendar
{
    /**
    * @class WeatherInfo - przechowuje informacje o pogodzie pobrane z zewnętrznego API (Open Weather)
    **/
    class WeatherInfo
    {
        /**
        @class coord - współrzędne geograficzne miasta (mniej istotne)
        **/
        public class coord
        {
            /**
            * @var lon - długość geograficzna
            **/
            public double lon { get; set; }
            /**
            * @var lat - szerokość geograficzna
            **/
            public double lat { get; set; }
        }

        /**
        * class weather - główne informacje
        **/
        public class weather
        {
            /**
            * @var main - ogólne warunki
            **/
            public string? main { get; set; }

            /**
            * @var description - szczegółowe warunki
            **/
            public string? description { get; set; }

            /**
            * @var icon - kod ikony
            **/
            public string? icon { get; set; }
        }

        /**
        * @class main - ogólne informacje
        **/
        public class main
        {
            /**
            * @var temp - temperatura
            **/
            public double temp { get; set; }

            /**
            * @var pressure - ciśnienie
            **/
            public double pressure { get; set; }
            /**
            * @var humidity - wilgotność
            **/
            public double humidity { get; set; }
        }

        /**
        * @class wind - informacje o wietrze
        **/
        public class wind
        {
            /**
            * @var speed - prędkość wiatru w m/s
            **/
            public double speed { get; set; }
        }

        /**
        * @class sys - informacje o wschodzie i zachodzie słońca
        **/
        public class sys
        {
            /**
            * @var sunrise - wschód słońca (liczba sekund od 1 stycznia 1970 00:00:00)
            **/
            public long sunrise { get; set; }

            /**
            * @var sunset - zachód słońca (liczba sekund od 1 stycznia 1970 00:00:00)
            **/
            public long sunset { get; set; }
        }

        /**
        * @class root - klasa zawierająca w sobie wszystkie informacje
        **/
        public class root
        {
            /**
            * @var coord - współrzędne geograficzne
            **/
            public coord? coord { get; set; }

            /**
            * @var weather - warunki pogodowe
            **/
            public List<weather>? weather { get; set; }

            /**
            * @var main - główne informacje
            **/
            public main? main { get; set; }

            /**
            * @wind - wiatr
            **/
            public wind? wind { get; set; }

            /**
            * @var sys - wschód i zachód słońca
            **/
            public sys? sys { get; set; }
        }
    }
}