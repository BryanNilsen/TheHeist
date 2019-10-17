using System;

namespace HeistII
{
  public class Hacker : IRobber
  {
    public Hacker(string name, int skill, int percent)
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
      bank.AlarmScore -= SkillLevel;
      Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");
      if (bank.AlarmScore <= 0)
      {
        Console.WriteLine($"{Name} has disabled the alarm.");
      }
    }

    public override string ToString()
    {
      return $"HACKER: {Name} - Skill: {SkillLevel} - Cut: {PercentageCut}";
    }

  }
}