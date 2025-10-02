public class Solution {
    int em=0,d=0;
    public int MaxBottlesDrunk(int full, int ex) {
        if(full<ex)return full;
        d=em=full;
        full=0;
        while(em>=ex||full>0)
        {
            if(em>=ex)
            {
                full++;
                em-=ex;
                ex++;
            }
            else if(full>0)
            {
                d+=full;
                em+=full;
                full=0;
            }
        }
        return d;

    }
}