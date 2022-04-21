using System;

namespace Calendar
{
    /**
    * @class Item Klasa służy do instancji wyświetlanych elementów.
    **/
    public class Item
    {
        /**
        * @var Content Zawiera treść zadania.
        **/
        public string Content { get; set; }

        /**
        * @var IsMarked Ta zmienna mówi nam czy element jest zaznaczony czy nie.
        **/
        public bool IsMarked { get; set; }

        public Item(string content)
        {
            Content = content;
            IsMarked = false;
        }
    }
}
