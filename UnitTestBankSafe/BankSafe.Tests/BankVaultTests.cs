using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault valute;
        private Item item;
        [SetUp]
        public void Setup()
        {
            valute = new BankVault();
            item = new Item("me", "1");
        }

        [Test]
        public void AddItemShouldArgumentexeptionIfdoasntExist()
        {
            Assert.Throws<ArgumentException>(() => valute.AddItem("D1", item));
        }
        [Test]
        public void AddItemAlreadyExist()
        {

            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                valute.AddItem("A2", item);
                valute.AddItem("A2", new Item("Pesho", "3"));
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }
        [Test]
        public void WhenItemAlreadyExist_ShpuldExeption()
        {

            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                valute.AddItem("A2", item);
                valute.AddItem("B3", item);
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }
        [Test]
        public void AddedItemSuccessFuly()
        {
           string result = valute.AddItem("A2", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }
        [Test]
        public void RemoveItemShouldArgumentexeptionIfdoasntExist()
        {
            Assert.Throws<ArgumentException>(() => valute.RemoveItem("D1", item));
        }
        [Test]
        public void RemoveItemAlreadyExist()
        {

            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                valute.RemoveItem("A2", item);
                valute.RemoveItem("A2", new Item("Pesho", "3"));
            });

            Assert.AreEqual(ex.Message, $"Item in that cell doesn't exists!");
        }
        [Test]
        public void RemoveItemSuccessFuly()
        {
            valute.AddItem("A2", item);
            string result = valute.RemoveItem("A2", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }
    }
}