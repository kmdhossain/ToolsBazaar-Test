using FluentAssertions;
using NSubstitute;
using ToolsBazaar.Domain.CustomerAggregate;
using ToolsBazaar.Domain.ProductAggregate;
using ToolsBazaar.Domain.OrderAggregate;
using ToolsBazaar.Web.Controllers;
using Xunit;
///using Microsoft.VisualStudio.ToolsBazaar.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using ToolsBazaar.Persistence;
namespace ToolsBazaar.Tests;

public class Tests
{
    [Fact]
    public void SampleTest()
    {
        var x = 10;

        x.Should().Be(10);
    }

  

   
        [Fact]
        public void GetTopCustomers_ReturnsTopFiveCustomers_SortedByTotal_Spending()
        {
            // Arrange
            var startDate = new DateTime(2015, 1, 1);
            var endDate = new DateTime(2022, 12, 31);

            var customers = new List<Customer>
            {
                // Add customer data here
            };

            var orders = new List<Order>
            {
                // Add order data here
            };

            var products = new List<Product>
            {
                // Add product data here
            };

          

            // Act
            

            // Assert
            
        }
    }




