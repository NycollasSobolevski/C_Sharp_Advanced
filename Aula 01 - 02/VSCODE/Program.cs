using System.Threading;
var temp = new System.Diagnostics.Stopwatch();
temp.Start();

int count=0;
// for (int i = 0; i < 10_000; i++)
batalha bat = new batalha();
Parallel.For(0,10_000, i=>
{
    bat.attacker  = 1000;
    bat.defenders = 583;
    //TODO: implementar o lock de forma que ele nao pegue a função inteira!!!
    lock (bat.rand)
    {
        if(bat.atack()){
            count++;
        }
    }
});


temp.Stop();
System.Console.WriteLine(count);

System.Console.WriteLine($"Duration: {temp.ElapsedMilliseconds} ms");