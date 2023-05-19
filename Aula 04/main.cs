using System;
using static FunctionUtil;

class Program {
  public static void Main (string[] args)
  {
    var f = new Constant(10) - new Constant(5) - new Constant(3);

    Console.WriteLine(f);
  }
}