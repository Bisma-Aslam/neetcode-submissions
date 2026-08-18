public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int res=0;
        foreach(string w in words){
            bool check=true;
            
            foreach(char c in w){
            if(!allowed.Contains(c)){
                check=false;
                break;
            }
            }
            if(check) res++;
            
        
        }
        return res;
        
    }
}