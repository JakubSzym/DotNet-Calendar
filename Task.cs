using System;

namespace Calendar
{
    /**
    * Ta klasa jest potrzebna do mapowania obiektowo-relacyjnego i obsługi bazy danych.
    **/
    public class Task
    {
        /**
        * Zawiera unikalny numer zadania.
        **/
        public int ID { get; set; }

        /**
        * Zawiera treść zadania do wykonania.
        **/
        public string Name { get; set; }

        /**
        * Zawiera dzień, w którym zadanie ma być wykonane.
        **/
        public DateTime? Date { get; set; }
    }
}
