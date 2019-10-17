using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistII
{
  public class ReconReport
  {

    public void RunReport(Bank bank)
    {
      Dictionary<string, int> bankProps = new Dictionary<string, int>()
      {
        {"Alarm", bank.AlarmScore},
        {"Security Guards", bank.SecurityGuardScore},
        {"Vault Lock", bank.VaultScore}
      };

      string MostSecure = bankProps.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
      string LeastSecure = bankProps.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

      Console.WriteLine($"$$$$$ RECON REPORT FOR: {bank.Name} $$$$$");
      Console.WriteLine($"Most Secure: {MostSecure} - Least Secure: {LeastSecure}");

    }
  }
}