using NUnit.Framework;

namespace SafariPark
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[TestCase("Leonard", "Atorough", "Leonard Atorough")]
        //[TestCase("", "", " ")]
        //public void GetFullNameTest(string fName, string lName, string expected)
        //{
        //    var subject = new Person(fName, lName);
        //    var fullName = subject.GetFullName();

        //    Assert.AreEqual(expected, fullName);
        //}

        //[Test]
        //public void AgeTest()
        //{
        //    var leonard = new Person("Leonard", "Atorough"){ Age = -23 };

        //    Assert.AreEqual(0, leonard.Age);

        //}



    //VEHICLE TESTS
        //[Test]
        //public void whenADefaultVehicleMovesTwiceItsPositionIs20()
        //{
        //    Vehicle vehicle = new Vehicle();
        //    var result = vehicle.Move(2);

        //    Assert.AreEqual(20, vehicle.Position);
        //    Assert.AreEqual("Moving along 2 times", result);
        //}

        //[Test]
        //public void whenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        //{
        //    Vehicle vehicle = new Vehicle(5, 40);
        //    var result = vehicle.Move();

        //    Assert.AreEqual(40, vehicle.Position);
        //    Assert.AreEqual("Moving along", result);
        //}

        //[Test]
        //public void VehicleOfCapacity5WillNotAcceptNegativePassengers()
        //{
        //    Vehicle vehicle = new Vehicle(5) { NumPassengers = -10 };

        //    Assert.AreEqual(0, vehicle.NumPassengers);
        //}

        //[Test]
        //public void VehicleOfCapacity5WillNotAcceptMorePassengersThanCapacity()
        //{
        //    Vehicle vehicle = new Vehicle(5) { NumPassengers = 10 };

        //    Assert.AreEqual(5, vehicle.NumPassengers);
        //}

        //[Test]
        //public void VehicleWillSpeedUp()
        //{
        //    Vehicle vehicle = new Vehicle();

        //    var x = vehicle.SpeedUp();

        //    Assert.AreEqual(20, vehicle.Speed);
        //    Assert.AreEqual("Speeding up", x);
        //}

        //[Test]
        //public void VehicleWillSlowDown()
        //{
        //    Vehicle vehicle = new Vehicle(10, 40);

        //    var x = vehicle.SlowDown();

        //    Assert.AreEqual(30, vehicle.Speed);
        //    Assert.AreEqual("Slowing down", x);

        //}

        //[Test]
        //public void VehicleWillNotSlowBelowZero()
        //{
        //    Vehicle vehicle = new Vehicle(2, 9);

        //    var x = vehicle.SlowDown();

        //    Assert.AreEqual(0, vehicle.Speed);
        //    Assert.AreEqual("Stopped", x);
        //}

        //AIRPLANE TESTS
        [TestCase(4000, 4000)]
        [TestCase(35000, 30000)]
        public void AirplaneWillAscendToLimit(int altitude, int expected)
        {
            Airplane airplane = new Airplane(200, "KLM", 700, 200);
            airplane.Ascend(altitude);
            Assert.AreEqual(expected, airplane.Altitude);
        }


        [TestCase(2000, 2000)]
        [TestCase(5000, 0)]
        public void AirplaneWillDescend(int altitude, int expected)
        {
            Airplane airplane = new Airplane(200, "KLM", 700, 200);
            airplane.Ascend(4000);
            airplane.Descend(altitude);

            Assert.AreEqual(expected, airplane.Altitude);
        }


        [Test]
        public void MovingAirPlane()
        {
            Airplane airplane = new Airplane(200, "KLM", 700, 200);
            airplane.Ascend(2000);
            var result = airplane.Move();

            Assert.AreEqual(200, airplane.Position);
            Assert.AreEqual("Moving along at an altitude of 2000 meters.", result);
        }


        [Test]
        public void MovingAirPlanemultipleTimes()
        {
            Airplane airplane = new Airplane(200, "KLM", 700, 200);
            airplane.Ascend(2000);
            var result = airplane.Move(5);

            Assert.AreEqual(1000, airplane.Position);
            Assert.AreEqual("Moving along 5 times at an altitude of 2000 meters.", result);
        }


        [Test]
        public void CorrectAirplaneDetailsWritten()
        {
            Airplane airplane = new Airplane(200, "KLM", 700, 200) { NumPassengers = 200 };
            airplane.Ascend(2000);
            var result = airplane.Move();

            Assert.AreEqual("Thank you for flying KLM: SafariPark.Airplane Capacity: 200 Passengers: 200 Speed: 200 Position: 200 Altitude: 2000", airplane.ToString());
        }
    }
    }