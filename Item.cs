using System;

namespace Calendar
{
    /**
    * Klasa służy do instancji wyświetlanych elementów.
    **/
    public class Item
    {
        /**
        * Zawiera treść zadania.
        **/
        public string Content { get; set; }

        /**
        * Ta zmienna mówi nam czy element jest zaznaczony czy nie.
        **/
        public bool IsMarked { get; set; }

        /**
        * @brief konstruktor klasy Item
        * @param content - treść zadania
        **/
        public Item(string content)
        {
            Content = content;
            IsMarked = false;
        }
    }
}
