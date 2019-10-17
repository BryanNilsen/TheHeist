using System;

namespace HeistII
{
  public class LockSpecialist : IRobber
  {

    public LockSpecialist(string name, int skill, int percent)
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
      bank.VaultScore -= SkillLevel;
      Console.WriteLine($"{Name} is picking the lock to the vault. Decreased security by {SkillLevel} points.");
      if (bank.VaultScore <= 0)
      {
        Console.WriteLine($"{Name} has opened the vault.");
      }
    }

    public override string ToString()
    {
      return $"LOCK SPECIALIST: {Name} - Skill: {SkillLevel} - Cut: {PercentageCut}";
    }

  }
}
