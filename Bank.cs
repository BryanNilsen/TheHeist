using System;

namespace HeistII
{
  public class Bank
  {
    public Bank()
    {
      Random rnd = new Random();
      CashOnHand = rnd.Next(50_000, 1_000_000);
      AlarmScore = rnd.Next(0, 100);
      VaultScore = rnd.Next(0, 100);
      SecurityGuardScore = rnd.Next(0, 100);
    }
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }

    public bool IsSecure()
    {
      if (CashOnHand + AlarmScore + VaultScore + SecurityGuardScore >= 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
