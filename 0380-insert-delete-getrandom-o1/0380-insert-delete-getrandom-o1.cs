public class RandomizedSet {

    List<int>RS;
    Dictionary<int,int> freq;
    public RandomizedSet() {
        RS=new List<int>();
        freq=new Dictionary<int,int>();
    }
    
    public bool Insert(int val) {
        if(freq.ContainsKey(val))return false;
        else
        {
            freq[val]=1;
            RS.Add(val);
            return true;
        }
    }
    
    public bool Remove(int val) {
        if(!freq.ContainsKey(val))return false;
        else
        {
            freq.Remove(val);
            RS.Remove(val);
            return true;
        }
    }
    
    public int GetRandom() {
        Random rand = new Random();
        int index = rand.Next(RS.Count);
        int randomElement = RS[index];
        return randomElement;

    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */