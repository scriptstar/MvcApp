using System;
using Xunit;
using MvcApp.Models;

namespace MvcApp.Tests
{
    public class PrimeService_IsPrimeShould
    {
		private readonly PrimeService _primeService;

		public PrimeService_IsPrimeShould()
		{
			_primeService = new PrimeService();
		}

		[Fact]
		public void ReturnFalseGivenValueOf1()
		{
			var result = _primeService.IsPrime(1);

			Assert.False(result, $"1 should not be prime");
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		[InlineData(1)]
		public void ReturnFalseGivenValuesLessThan2(int value)
		{
			var result = _primeService.IsPrime(value);

			Assert.False(result, $"{value} should not be prime");
		}

		[Fact]
		public void PassingTest()
		{
			Assert.Equal(4, Add(2, 2));
		}

		int Add(int x, int y)
		{
			return x + y;
		}
    }
}
