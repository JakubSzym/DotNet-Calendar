using System;

namespace Calendar
{
    /**
    * @class Task Klasa ta jest potrzebna do mapowania obiektowo-relacyjnego i obsługi Bazy danych.
    **/
    public class Task
    {
        /**
        * @var ID Zawiera uniklany numer zadania.
        **/
        public int ID { get; set; }

        /**
        * @var Name Zawiera treść zadania do wykonania.
        **/
        public string Name { get; set; }

        /**
        * @var Date Zawiera dzień, w którym zadanie ma być wykonane.
        **/
        public DateTime? Date { get; set; }
    }
}
