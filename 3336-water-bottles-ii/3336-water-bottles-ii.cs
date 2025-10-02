public class Solution {
    int full=0,em=0,ex=0,d=0;
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        d=em=numBottles;
        ex=numExchange;
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