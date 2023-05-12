using System.Collections.Concurrent;
using System.Threading;
public class batalha
{
    public batalha(int atacantes, int defensores, int rodadas)
    {
        this.attacker = atacantes;
        this.defenders = defensores;
        this.round = rodadas;
    }

    int attacker { get; set; }
    int defenders { get; set; }
    int round { get; set; }
    Random rand = new Random();

    bool verify() => this.attacker > 1 && this.defenders > 0  ? true  : false;

    public bool atack(){
        
        int[] atackList = new int[3];
        int[] defendList = new int[3];
        
        while(verify())
        {
            int menor = Math.Min(attacker,defenders);
            for (int j = 0; j < 3; j++)
            {
                atackList[j] = rand.Next(1,6);
                defendList[j] = rand.Next(1,6);
            }
            Array.Sort(atackList);
            Array.Sort(defendList);
            
            for (int i = 0; i < (menor < 3 ? menor : 3); i++)
            {
                    if(atackList[i] > defendList[i])
                        this.defenders--;
                    else
                        this.attacker--;
            }
        } 
        return (this.attacker > 1 ? true : false);
    }
}