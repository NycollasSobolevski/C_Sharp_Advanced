var temp = new System.Diagnostics.Stopwatch();
temp.Start();

int count=0;
for (int i = 0; i < 10_000; i++)
{
    batalha bat = new batalha(1000,583,1000);
    if(bat.atack()){
        count++;
    }
}


temp.Stop();
System.Console.WriteLine(count);

System.Console.WriteLine($"duração: {temp.ElapsedMilliseconds}");