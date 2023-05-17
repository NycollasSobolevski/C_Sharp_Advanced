using System.Collections.Concurrent;

public class batalha
{
    // public batalha(int atacantes, int defensores)
    // {
    //     this.attacker = atacantes;
    //     this.defenders = defensores;
    // }

    public int attacker { get; set; }
    public int defenders { get; set; }
    public Random rand = new Random();

    bool verify() => this.attacker > 1 && this.defenders > 0  ? true  : false;

    public bool atack(){
        
        int[] atackList = new int[3];
        int[] defendList = new int[3];
        
        while(verify())
        {
            int menor = Math.Min(attacker,defenders);
                for (int j = 0; j < 3; j++)
                {
                    atackList[j] = rand.Next(1,7);
                    defendList[j] = rand.Next(1,7);
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