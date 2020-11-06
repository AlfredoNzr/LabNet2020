using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PracticeEF.Logic.Implementations;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Logic.UnitTests
{
    [TestClass]
    public class CategoriesLogicTest
    {
        [TestMethod]
        public void GetOne_Test()
        {
            Categories categories = new Categories();
                
            categories.CategoryID = 15;
            categories.CategoryName = "CategoryTest";
            categories.Description = "test de categoria";


            var mockSet = new Mock<DbSet<Categories>>(); //Categoria falsa

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Categories).Returns(mockSet.Object); // me retorna una categoria falsa


            var mockLogic = new Mock<CategoriesLogic>(mockContext.Object); //CategoriesLogic Falso con NorthwindContext falso
            
            mockLogic.Setup(c => c.GetOne(15)).Returns(categories); //modificacion del comportamiento de GetOne

            var catLogic = mockLogic.Object; //instancia de un MockLogic

            var cat = catLogic.GetOne(15); 
            
            Assert.AreEqual(15, cat.CategoryID);
            Assert.AreEqual("CategoryTest", cat.CategoryName);
            Assert.AreEqual("test de categoria", cat.Description);

        }

        [TestMethod]
        public void GetAll_Test()
        {
            
            List<Categories> LstCategories = new List<Categories>();

            LstCategories.Add(new Categories() { CategoryID = 1, CategoryName = "CategoriaUNO" });
            LstCategories.Add(new Categories() { CategoryID = 2, CategoryName = "CategoriaDOS" });
            LstCategories.Add(new Categories() { CategoryID = 4, CategoryName = "CategoriaCUATRO" });

            var mockSet = new Mock<DbSet<Categories>>(); // Lista Categoria falsa
            var lstMockSet = mockSet.Object;

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Categories).Returns(lstMockSet); // me retorna una categoria falsa

            var mockLogic = new Mock<CategoriesLogic>(mockContext.Object); //CategoriesLogic Falso con NorthwindContext falso
            mockLogic.Setup(c => c.GetAll()).Returns(LstCategories); //modificacion del comportamiento de GetOne

            var catLogic = mockLogic.Object; //instancia de un MockLogic
            var cat = catLogic.GetAll();

            
            Assert.AreEqual(1, cat[0].CategoryID);
            Assert.AreEqual("CategoriaUNO", cat[0].CategoryName);

            Assert.AreEqual(2, cat[1].CategoryID);
            Assert.AreEqual("CategoriaDOS", cat[1].CategoryName);

            Assert.AreEqual(4, cat[2].CategoryID);
            Assert.AreEqual("CategoriaCUATRO", cat[2].CategoryName);

        }
    }
}
