public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int>count=new Dictionary<char,int>();
        foreach(char c in text){
            if(!count.ContainsKey(c)) count[c]=0;
            count[c]++;
        }
        Dictionary<char,int> balloon=new Dictionary<char,int>{
            {'b',1},{'a',1},{'l',2},{'o',2},{'n',1}
        };
        int res=text.Length;
        foreach(var entry in balloon){
            int counter=count.ContainsKey(entry.Key)?count[entry.Key]:0;
            res=Math.Min(res,counter/entry.Value);
        }
        return res;
        
    }
}