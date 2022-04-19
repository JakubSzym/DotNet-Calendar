using System;

namespace Calendar
{
    public class Item
    {
        public string Content { get; set; }
        public bool IsMarked { get; set; }

        public Item(string content)
        {
            Content = content;
            IsMarked = false;
        }
    }
}
