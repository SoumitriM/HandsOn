using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;

namespace GenericMedicineTest
{
    [TestFixture]
    public class Class1
    {
        public Program program;

        [SetUp]
        public void Start()
        {
            program = new Program();
        }
        [Test]
        [TestCase("medicine_name", "genericname", "composition", "2021-08-12", 10)]
        public void CreateMedicine_ReturnMedicine(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result, Is.TypeOf<Medicine>());
        }

        [Test]
        [TestCase("medicine_name", "", "composition", "2021-08-12", 2)]
        public void CreateMedicine_GenericNameNull_ThrowException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("name", "generic_name", "composition", "2021-08-12", -1)]
        public void CreateMedicine_MedicinePriceNegative_ThrowException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("name", "generic_name", "composition", "2020-08-08", 2)]
        public void CreateMedicine_ExpiryDateLessThanCurrDate_ThrowException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase(1, "2021-08-12", "address")]
        public void CreateCarton_ReturnCarton(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "abc",
                GenericMedicineName = "abc",
                Composition = "abc",
                ExpiryDate = new DateTime(2021, 12, 8),
                PricePerStrip = 1
            };

            var result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(result, Is.TypeOf<CartonDetail>());
        }

        [Test]
        [TestCase(-1, "2021-05-19", "address")]
        public void CreateCarton_MedicineStripCountNegative_ThrowException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "abc",
                GenericMedicineName = "abc",
                Composition = "abc",
                ExpiryDate = new DateTime(2021, 4, 7),
                PricePerStrip = 1
            };

            Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
        }

        [Test]
        [TestCase(2, "2021-02-15", "address")]
        public void CreateCarton_LaunchDateLessthanCurrDate_ThrowException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "name",
                GenericMedicineName ="genericnme",
                Composition = "composition",
                ExpiryDate = new DateTime(2022, 7, 4),
                PricePerStrip = 1
            };

            Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
        }

        [Test]
        [TestCase(3, "2021-05-06", "address", null)]
        public void CreateCarton_MedicineNull_ReturnNull(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine)
        {
            var result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
