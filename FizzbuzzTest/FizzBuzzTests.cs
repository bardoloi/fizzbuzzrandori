namespace FizzbuzzTest
{
    using System.Linq;
    using FizzbuzzRandori;
    using Shouldly;

    public class FizzBuzzTests
    {
        private readonly FizzBuzz _fizzBuzz;

        public FizzBuzzTests()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        public void ShouldHave100Numbers()
        {
            _fizzBuzz.GetNumberQty().ShouldBe(100);
        }

        public void FirstElementReturnedShouldBe1()
        {
            _fizzBuzz.GetMessagesToShow().First().ShouldBe("1");
        }

        public void ShouldHaveSequentialNumbers()
        {
            _fizzBuzz.GetMessagesToShow()[0].ShouldBe("1");
            _fizzBuzz.GetMessagesToShow()[1].ShouldBe("2");
            _fizzBuzz.GetMessagesToShow()[49].ShouldBe("50");
            _fizzBuzz.GetMessagesToShow()[99].ShouldBe("100");
        }

        public void ShouldSayFizzWhenPositionIsDivisibleBy3()
        {
            var messages = _fizzBuzz.GetMessagesToShow();

            messages[2].ShouldBe("Fizz");
            messages[5].ShouldBe("Fizz");
        }
    }
}
