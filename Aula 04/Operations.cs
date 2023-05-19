using System;
using System.Linq;
using System.Collections.Generic;



public class Sum : Function
{
  private List<Function> funcs = new List<Function>();
  public void Add(Function func)
    => this.funcs.Add(func);

  protected override double get(double x)
    => this.funcs.Sum(f => f[x]);
  
  public override Function Derive()
  {
    Sum result = new Sum();
    
    foreach (var f in this.funcs)
      result.Add(f.Derive());
    
    return result;
  }
  
  public override string ToString()
  {
    string str = "(";

    foreach (var f in this.funcs)
      str += f.ToString() + " + ";

    return str.Substring(0, str.Length - 3) + ")";
  }
}

public class Mult : Function
{
  private List<Function> funcs = new List<Function>();
  public void Add(Function func)
    => this.funcs.Add(func);

  protected override double get(double x)
  {
    double result = 1;
    
    foreach (var f in this.funcs)
      result *= f[x];
      
    return result;
  }
  
  public override Function Derive()
  {
    return null; // ainda não fiz kk (ainda hua hua)
  }
  
  public override string ToString()
  {
    string str = "";

    foreach (var f in this.funcs)
      str += f.ToString() + " * ";

    return str.Substring(0, str.Length - 3);
  }
}

public class Div : Function
{
  private List<Function> funcs = new List<Function>();
  public void Add(Function func) => this.funcs.Add(func);

  protected override double get(double x)
  {
      double result = funcs[0][x];
      for (int i = 1; i < funcs.Count; i++)
        result /= funcs[i][x];
      return result;
  }
    public override string ToString()
  {
    string str = "";

    foreach (var f in this.funcs)
      str += f.ToString() + " / ";

    return str.Substring(0, str.Length - 3);
  }
  public override Function Derive() => null;
}

public class Sub : Function
{
    private List<Function> funcs = new List<Function>();
    public void Add(Function func) => funcs.Add(func);

    protected override double get(double x)
    {
        double result = this.funcs[0][x];
        for (int i = 1; i < this.funcs.Count; i++)
        {
            result -= funcs[i][x];
        }
        return result;
    }
     public override string ToString()
  {
    string str = "";

    foreach (var f in this.funcs)
      str += f.ToString() + " - ";

    return str.Substring(0, str.Length - 3);
  }
    public override Function Derive() => null;
}