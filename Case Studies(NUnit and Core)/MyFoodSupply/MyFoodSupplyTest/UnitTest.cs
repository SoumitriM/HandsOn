using System;
using NUnit.Framework;
using MyFoodSupply;

namespace MyFoodSupplyTest
{
    [TestFixture]
    public class UnitTest
    {
        public Program program;
        [SetUp]
        public void Start()
        {
            program = new Program();
        }
        [Test]
        [TestCase("name", 1, "2021-08-12", 35.50)]
        public void CreateFoodDetail_ReturnFoodDetail(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = program.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(result, Is.TypeOf<FoodDetail>());
        }

        [Test]
        [TestCase(null, 3, "2021-08-12", 55.50)]
        [TestCase("gh", 3, "2021-08-12", 55.50)]
        public void CreateFoodDetail_FoodNameEmpty_ThrowException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("name", 1, "2021-08-12", -1)]
        public void CreateFoodDetail_FoodPriceNegative_ThrowException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("name", 2, "2022-08-12", 10)]
        public void CreateFoodDetail_ExpiryDateLessthanCurrentDate_ThrowException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase(5, "2021-08-12", "sellername", 5.50)]
        public void CreateSupplyDetail_ReturnSupplyDetail(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "foodname",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2022, 8 , 12),
                Price = 50
            };

            var result = program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.TypeOf<SupplyDetail>());
        }

        [Test]
        [TestCase(-1, "2021-08-12", "sellername", 10.50)]
        public void CreateSupplyDetail_FoodCountNegative_ThrowException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "name",
                DishType = (FoodDetail.Category)3,
                ExpiryDate = new DateTime(2022, 8, 12),
                Price = 50.50
            };

            Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        [Test]
        [TestCase(10, "2020-08-12", "sellername", 10.50)]
        public void CreateSupplyDetail_RequestDateLessThanCurrentDate_ThrowException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "foodname",
                DishType = (FoodDetail.Category)2,
                ExpiryDate = new DateTime(2021, 8, 12),
                Price = 50.50
            };

            Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }
        [Test]
        [TestCase(3, "2021-08-12", "sellername", 10.50, null)]
        public void CreateSupplyDetail_FoodItemNull_ReturnNull(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            var result = program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
