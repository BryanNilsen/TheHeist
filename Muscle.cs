using System;

namespace HeistII
{
  public class Muscle : IRobber
  {
    public Muscle(string name, int skill, int percent)
    {
      Name = name;
      SkillLevel = skill;
      PercentageCut = percent;
    }
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill(Bank bank)
    {
      bank.SecurityGuardScore -= SkillLevel;
      Console.WriteLine($"{Name} is subduing the security guards. Decreased security by {SkillLevel} points.");
      if (bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"{Name} has 'taken care of' the security guards.");
      }
    }

    public override string ToString()
    {
      return $"MUSCLE: {Name} - Skill: {SkillLevel} - Cut: {PercentageCut}";
    }

  }
}
