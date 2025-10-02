public class Solution {
    int em=0,d=0;
    public int MaxBottlesDrunk(int full, int ex) {
        if(full<ex)return full;
        d=em=full;
        while(em>=ex)
        {
            d++;
            em-=ex-1;//1 that taken by full
            ex++;
        }
        return d;

    }
}