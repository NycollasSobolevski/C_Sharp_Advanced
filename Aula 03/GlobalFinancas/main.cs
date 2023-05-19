using System;

class Program
{
  public static void Main (string[] args)
  {
    var builder = Company.GetBuilder();
 
    builder
        .SetName("Mercado Libre")
        .InArgentina()
        .SetInitialCapital(20_000_000);
     
    builder
        .AddEmploye("Marquitos Guapo", 50_000)
        .AddEmploye("Paulito Pino", 20_000);
     
    Company.New(builder);
     
    // Me rendí, me voy a Brasil
    builder = Company.GetBuilder();
     
    builder
        .SetName("Mercado Livre")
        .InBrazil()
        .SetInitialCapital(1_000_000);
     
    builder
        .AddEmploye("Marcos Bonito", 2_500)
        .AddEmploye("Paulo Pinheiro", 1_000);
     
    Company.New(builder);
     
    builder = Company.GetBuilder();

    builder
      .SetName("Free Market")
      .SetInitialCapital(30_000_000)
      .InEua();
    builder
    .AddEmploye("Harvey Junior", 10_000);
    Company.New(builder);
    
    Employe employe = new Employe();
    employe.Name = "Xispita";
    employe.Wage = 2_000;
    Company.Current.Contract(employe);
     
    Company.Current.Dismiss("Marcos Bonito");
     
    Company.Current.PayWages();
    System.Console.WriteLine($"{Company.Current.Name} Company");
    foreach (var employes in Company.Current.Employes)
    {
      System.Console.Write($"{employes.Name} - s");
    } 
  }
}