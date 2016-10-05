using System;
using System.Collections;

namespace Books
{
    public class Inventory
    {
        private static Inventory mInstance;
        private Hashtable mLibraryBooks;

        private Inventory()
        {
            mLibraryBooks = new Hashtable();
        }

        public static Inventory Instance
        {
            get
            {
                if (mInstance == null)
                    mInstance = new Inventory();
                return mInstance;
            }
        }

        public Book this [int BookID]
        {
            get { return (Book)mLibraryBooks[BookID]; }
            set { mLibraryBooks[BookID] = value; }
        }
    }

    public class Book
    {
        private string mTitle;
        private string mAuthor;

        public Book(string title, string author)
        {
            mTitle = title;
            mAuthor = author;
        }

        public override string ToString()
        {
            return mTitle + ", written by: " + mAuthor;
        }
    }
}
