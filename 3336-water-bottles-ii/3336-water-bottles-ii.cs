public class Solution {
    public int MaxBottlesDrunk(int d, int ex) {
        int em=d;
        while(em>=ex)
        {
            d++;
            em-=ex-1;//1 that taken by full
            ex++;
        }
        return d;

    }
}