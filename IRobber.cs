
namespace HeistII
{
  public interface IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      // nothing here yet
    }
  }
}

// Each type of robber will have a special skill that will come in handy while knocking over banks. Start by creating an interface called IRobber. The interface should include:

// A string property for Name
// An integer property for SkillLevel
// An integer property for PercentageCut
// A method called PerformSkill that takes in a Bank parameter and doesn't return anything.