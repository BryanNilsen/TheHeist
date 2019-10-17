using System;
using System.Collections.Generic;

namespace HeistII
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("THE HEIST -- PART II");

      // Instantiate a bunch of robbers
      Hacker specs = new Hacker("Specs", 30, 15);
      Hacker neo = new Hacker("Neo", 80, 40);
      Hacker askingalot = new Hacker("Askingalot", 70, 35);
      Muscle luca = new Muscle("Luca Brasi", 80, 40);
      Muscle mrsqueeze = new Muscle("Mr. Squeeze", 40, 20);
      Muscle daisy = new Muscle("Daisy", 30, 15);
      LockSpecialist mrquiet = new LockSpecialist("Mr. Quiet", 50, 25);
      LockSpecialist fenster = new LockSpecialist("Fenster", 20, 10);
      LockSpecialist pickles = new LockSpecialist("Pickles", 45, 22);

      // Create a (rolodex) list of robbers
      List<IRobber> rolodex = new List<IRobber>()
      { specs, neo, askingalot, luca, mrquiet, mrsqueeze, daisy, fenster, pickles };

      bool isAddingOperative = true;

      // New Operative Value Declarations
      string newOperativeName;
      string newOperativeSpecialty = "";
      int newOperativeSkillLevel = 0;
      int newOperativePercentageCut = 0;

      // Add new operative
      while (isAddingOperative)
      {
        Console.WriteLine($"There are {rolodex.Count} operatives in your Rolodex.");
        rolodex.ForEach(Console.WriteLine);

        // Enter Name
        Console.Write("Enter name of new operative or press 'enter' to skip >> ");
        string nameInput = Console.ReadLine();

        if (nameInput == "")
        {
          isAddingOperative = false;
          break;
        }
        else
        {
          newOperativeName = nameInput;
        }

        // Choose Specialty
        Console.WriteLine($"Choose a Specialty for {nameInput}:");
        Console.WriteLine("[1] Hacker");
        Console.WriteLine("[2] Muscle");
        Console.WriteLine("[3] Lock Specialist");
        Console.Write("Enter number >> ");

        bool isSelectingSpecialty = true;
        while (isSelectingSpecialty == true)
        {
          int specialtyInput = 0;
          // Handle error on non-integer input
          bool success = int.TryParse(Console.ReadLine(), out specialtyInput);
          if (!success)
          {
            Console.Write("Please enter a number, silly >> ");
          }
          else
          {
            // Handle invalid integer input
            if (specialtyInput < 1 || specialtyInput > 3)
            {
              Console.WriteLine("Invalid response. Please type 1, 2, or 3.");
            }
            else
            {
              switch (specialtyInput)
              {
                case 1:
                  newOperativeSpecialty = "Hacker";
                  isSelectingSpecialty = false;
                  break;
                case 2:
                  newOperativeSpecialty = "Muscle";
                  isSelectingSpecialty = false;
                  break;
                case 3:
                  newOperativeSpecialty = "Lock Specialist";
                  isSelectingSpecialty = false;
                  break;
              }
            }
          }
        }

        Console.WriteLine();

        // Enter Skill Level
        Console.Write($"Enter {newOperativeSpecialty} specialty level (from 1 to 100) >> ");

        bool isSelectingSkill = true;
        while (isSelectingSkill == true)
        {
          int skillInput = 0;
          // Handle error on non-integer input
          bool skillSuccess = int.TryParse(Console.ReadLine(), out skillInput);

          if (!skillSuccess || skillInput < 1 || skillInput > 100)
          {
            Console.Write("Please enter a NUMBER between 1 and 100 >> ");
          }
          else
          {
            newOperativeSkillLevel = skillInput;
            break;
          }
        }


        // Enter Percentage Cut
        Console.Write($"Enter {newOperativeName}'s percentage cut of the loot (from 1 to 100) >> ");

        bool isSelectingPercentageCut = true;
        while (isSelectingPercentageCut == true)
        {
          int percentInput = 0;
          // Handle error on non-integer input
          bool percentSuccess = int.TryParse(Console.ReadLine(), out percentInput);

          if (!percentSuccess || percentInput < 1 || percentInput > 100)
          {
            Console.Write("Please enter a NUMBER between 1 and 100 >> ");
          }
          else
          {
            newOperativePercentageCut = percentInput;
            break;
          }
        }

        // Create new Operative Here (currently listing details)

        switch (newOperativeSpecialty)
        {
          case "Hacker":
            Hacker hh = new Hacker(newOperativeName, newOperativeSkillLevel, newOperativePercentageCut);
            rolodex.Add(hh);
            break;
          case "Muscle":
            Muscle mm = new Muscle(newOperativeName, newOperativeSkillLevel, newOperativePercentageCut);
            rolodex.Add(mm);
            break;
          case "Lock Specialist":
            LockSpecialist ll = new LockSpecialist(newOperativeName, newOperativeSkillLevel, newOperativePercentageCut);
            rolodex.Add(ll);
            break;
        }
      }
      Console.Clear();
      Console.WriteLine("Finished Adding Operatives.");
      Bank testBank = new Bank();
      ReconReport test1 = new ReconReport();
      test1.RunReport(testBank);

      Console.WriteLine("Hooray!");
    }
  }
}
