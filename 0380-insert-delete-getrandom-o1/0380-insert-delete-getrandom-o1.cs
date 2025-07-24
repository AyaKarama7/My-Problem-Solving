public class RandomizedSet {

    HashSet<int>RS;
    public RandomizedSet() {
        RS=new HashSet<int>();
    }
    
    public bool Insert(int val) {
        if(RS.Contains(val))return false;
        else
        {
            RS.Add(val);
            return true;
        }
    }
    
    public bool Remove(int val) {
        if(!RS.Contains(val))return false;
        else
        {
            RS.Remove(val);
            return true;
        }
    }
    
    public int GetRandom() {
        Random rand = new Random();
        int index = rand.Next(RS.Count);
        int randomElement = RS.ElementAt(index);
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