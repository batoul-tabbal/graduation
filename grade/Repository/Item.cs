﻿namespace grade.Repository
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Expiration {  get; set; }

    }
}
