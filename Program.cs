using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      // My age currently
      int myAge = 31;
      // The first year of a medium-sized dog’s life equals approximately 15 years of a human’s life
      int dogFirstYear = 15;
      // The second year of a dog’s life equals about nine years for a human.
      int dogSecondYear = 9;
      //And after that, every human year equals approximately four or five years for a dog. Let's say 4 for this exercise.
      int dogRemainingYears = 4;

      // Calculating my age in dog years
      int myAgeInDogYears = (myAge - 2) * dogRemainingYears + dogFirstYear + dogSecondYear;

      // Printing out the sum into the console
      Console.WriteLine(myAgeInDogYears);
    }
  }
}
