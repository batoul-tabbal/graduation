﻿namespace grade.Repository
{
    public class Section
    {
        public int SectionId { get; set; }
        public double SectionArea { get; set; }
        public double SectionHigh { get; set; }
        public int NumOfCategories { get; set; }
        public int NumOfItems { get; set; }
        public int NumOfShelves { get; set; }


        public Section(int sectionId, double area, double high, int category , int item, int shelf)
        { 
            SectionId = sectionId;
            SectionArea = area;
            SectionHigh = high;
            NumOfCategories = 0;
            NumOfItems = 0;
            NumOfShelves = 0;
        }
        public void AddCategory( int count)
        {
            NumOfCategories += count;
        }
        public void RemoveCategory(int count)
        {
            if (count <= NumOfCategories)
            {
                NumOfCategories -= count;
            }
            else
            {
                throw new InvalidOperationException(" Cannot remove more category than available");
            }
        }
        public void AddItems(int count1)
        {
            NumOfItems += count1;
        }
        public void RemoveItems(int count1)
        {
            if (count1 <= NumOfItems)
            {
                NumOfItems -= count1;
            }
            else
            {
                throw new InvalidOperationException(" Cannot remove more items than available");
            }
        }
        public void AddShelf(int count2)
        {
            NumOfShelves += count2;
        }
        public void RemoveShelf(int count2)
        {
            if (count2 <= NumOfShelves)
            {
                NumOfShelves -= count2;
            }
            else
            {
                throw new InvalidOperationException(" Cannot remove more shelves than available");
            }
        }
    }
}
