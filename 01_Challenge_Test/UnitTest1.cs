using System;
using _01_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Method()
        {
            //List<Menu> = new <Menu>List()
            Menu_Repository _menuList = new Menu_Repository();
            _menuList.SeedList();

            Assert.AreEqual(3, _menuList.GetMenu().Count);

        }

        [TestMethod]
        public void AddMethod()
        {
            Menu_Repository _menuList = new Menu_Repository();
            Menu content = new Menu();

            _menuList.AddToMenu(content);


            Assert.AreEqual(1, _menuList.GetMenu().Count);

        }
        [TestMethod]
        public void RemoveMethod()
        {
            Menu_Repository _menuList = new Menu_Repository();
            _menuList.SeedList();

            _menuList.RemoveFromMenu(1);
            Assert.AreEqual(_menuList.GetMenu().Count, 2);


        }
        [TestMethod]
        public void CreateMethod()
        {
            Menu_Repository _menuList = new Menu_Repository();
            _menuList.

        }

    }
}
