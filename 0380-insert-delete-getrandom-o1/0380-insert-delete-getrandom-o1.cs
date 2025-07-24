public class RandomizedSet {

    List<int>RS;
    Dictionary<int,int> freq;
     Random rand;
    public RandomizedSet() {
        RS=new List<int>();
        freq=new Dictionary<int,int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if(freq.ContainsKey(val))return false;
        else
        {
            freq[val]=RS.Count;
            RS.Add(val);
            return true;
        }
    }
    
    public bool Remove(int val) {
        if(!freq.ContainsKey(val))return false;
        else
        {
            int last=RS[^1];
            int idx=freq[val];
            RS[idx]=last;
            freq[last]=idx;
            RS.RemoveAt(RS.Count - 1);
            freq.Remove(val);
            return true;
        }
    }
    
    public int GetRandom() {
       
        int index = rand.Next(RS.Count);
        return RS[index];

    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */