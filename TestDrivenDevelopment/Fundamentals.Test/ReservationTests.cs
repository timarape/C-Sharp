using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals
{
    [TestClass]
    public class ReservationTests
    {
        Reservation reservation;
      

       [TestInitialize]
        public void SetUp()
        {
            reservation = new Reservation();
            

        }

        [TestMethod]
        public void CanBeCancelledBy_IfUserIsAdmin_ReturnTrue()
        {
            var currentUser = new User{ IsAdmin=true};

            var isAdmin = reservation.CanBeCancelledBy(currentUser);

            Assert.IsTrue(isAdmin);
        }

        [TestMethod]
        public void CanBeCancelledBy_IfUserIsNotAdmin_ReturnFalse()
        {
            var currentUser = new User { IsAdmin = false };

            var isAdmin = reservation.CanBeCancelledBy(currentUser);

            Assert.IsFalse(isAdmin);
        }

        [TestMethod]
        public void CanBeCancelledBy_IfCreatedTheTicket_ReturnTrue()
        {
            var currentUser = new User();
            reservation = new Reservation { MadeBy = currentUser };

            var canCancel = reservation.CanBeCancelledBy(currentUser);

            Assert.IsTrue(canCancel);
        }

        [TestMethod]
        public void CanBeCancelledBy_IfDidNotCreateTheTicket_ReturnFalse()
        {
          
            var currentUser = new User();
            reservation = new Reservation { MadeBy = new User() };

            var canCancel = reservation.CanBeCancelledBy(currentUser);

            Assert.IsFalse(canCancel);


        }

       
    }
}
