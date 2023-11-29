using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;
using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Shoul_Return_Room_Booking_Response_With_Request_Values()
        {
            //Arrange - implement data of the project
            var request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2021, 10, 20)
            };

            var processor = new RoomBookingRequestProcessor();

            //Act - implement test
            RoomBookingResult result = processor.BookRoom(request);

            //Assert
            //Assert.NotNull(result); //request validation con metodo tradizionale
            //Assert.Equal(request.FullName, result.FullName);
            //Assert.Equal(request.Email, result.Email);
            //Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull(); //request not null con pacchetto shouldly - potrebbe essere
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);

        }
    }
}
