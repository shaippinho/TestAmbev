using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace TestProject1
{

    [TestFixture]
    public class Tester
    {
        [Test]
        public void ShelfCanAcceptAndReturnItem()
        {
            Shelf shelf = new Shelf();
            shelf.Put("Orange");
            Assert.AreEqual(true, shelf.Take("Orange"));
        }

        [Test]
        public void ShelfReturnNothingWhenNull()
        {
            Shelf shelf = new Shelf();
            shelf.Put(null);
            Assert.AreEqual(false, shelf.Take(null));
            shelf.Put("");
            Assert.AreEqual(false, shelf.Take(""));
        }

        [Test]
        public void ShelfItemTakenOnly()
        {
            Shelf shelf = new Shelf();
            shelf.Put("Test");
            Assert.AreEqual(true, shelf.Take("Test"));
            Assert.AreEqual(false, shelf.Take("Test"));
        }

        [Test]
        public void ShelfDuplicateItem()
        {
            Shelf shelf = new Shelf();
            shelf.Put("Test");
            shelf.Put("Test");
            Assert.AreEqual(true, shelf.Take("Test"));
            Assert.AreEqual(true, shelf.Take("Test"));
        }

    }

    public class Shelf
    {
        private List<string> items = new List<string>();

        public void Put(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                this.items.Add(item);
            }
        }

        public bool Take(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }

            return false;
        }
    }
}