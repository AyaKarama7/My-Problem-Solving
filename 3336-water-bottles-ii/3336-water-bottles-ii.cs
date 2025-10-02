public class Solution {
    int full=0,em=0,ex=0,d=0;
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        d=em=numBottles;
        ex=numExchange;
        full=0;
        bool isDrink=false,isExchange;
        if(em>=ex)isExchange=true;
        else isExchange=false;
        while(isExchange||isDrink)
        {
            if(isExchange)
            {
                full++;
                isDrink=true;
                em-=ex;
                ex++;
                if(em>=ex)isExchange=true;
                else isExchange=false;
            }
            else if(isDrink)
            {
                d+=full;
                em+=full;
                full=0;
                isDrink=false;
                if(em>=ex)isExchange=true;
                else isExchange=false;
            }
        }
        return d;

    }
}