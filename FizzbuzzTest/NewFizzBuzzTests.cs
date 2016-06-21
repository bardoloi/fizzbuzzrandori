using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzTest
{
    using FizzbuzzRandori;
    using Shouldly;

    public class NewFizzBuzzTests
    {
        // input: number => output: string representing the number
        public void ShouldRenderStringRepresentationOfInputNumber()
        {
            var fizzBuzz = new NewFizzBuzz();

            fizzBuzz.Render(1).ShouldBe("1");
            fizzBuzz.Render(7).ShouldBe("7");
            fizzBuzz.Render(11).ShouldBe("11");
        }

        // if i is divisible by 3, render "Fizz"
        public void ShouldRenderFizzIfInputIsDivisibleBy3()
        {
            var fizzBuzz = new NewFizzBuzz();

            fizzBuzz.Render(3).ShouldBe("Fizz");
            fizzBuzz.Render(9).ShouldBe("Fizz");
            fizzBuzz.Render(21).ShouldBe("Fizz");
        }

        // should render buzz if number divisible by 5
        public void ShouldRenderBuzzIfInputIsDivisibleBy5()
        {
            var fizzBuzz = new NewFizzBuzz();

            fizzBuzz.Render(5).ShouldBe("Buzz");
            fizzBuzz.Render(20).ShouldBe("Buzz");
            fizzBuzz.Render(25).ShouldBe("Buzz");
        }

        // should render "FizzBuzz" if diviible by both 3 and 5
        public void ShouldRenderFizzBuzzIfInputIsDivisibleBy3And5()
        {
            var fizzBuzz = new NewFizzBuzz();

            fizzBuzz.Render(15).ShouldBe("FizzBuzz");
            fizzBuzz.Render(30).ShouldBe("FizzBuzz");
            fizzBuzz.Render(45).ShouldBe("FizzBuzz");
        }

    }
}
