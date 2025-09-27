public class RandomizedSet {
    Dictionary<int,int>map;
    List<int>set;
    int idx;
    Random rand;
    public RandomizedSet() {
        map=new Dictionary<int,int>();
        set=new List<int>();
        rand=new Random();
        idx=0;
    }
    
    public bool Insert(int val) {
        if(map.ContainsKey(val))return false;
        map[val]=idx;
        idx++;
        set.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!map.ContainsKey(val))return false;
        set[map[val]]=set[idx-1];
        map[set[idx-1]]=map[val];
        set.RemoveAt(idx-1);
        map.Remove(val);
        idx--;
        return true;
    }
    
    public int GetRandom() {
        return set[rand.Next(idx)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */