public class Solution{
    public bool IsAnagram(string s ,string t){
        if(s.Length!=t.Length){
            Console.WriteLine("not anagram");
            return false;
        }
        Dictionary<char,int>countS=new Dictionary<char,int>();
        foreach(char c in s){
            if(countS.ContainsKey(c)){
                countS[c]++;
            }else{
                countS[c]=1;
            }
        }
        foreach(char c in t){
            if(countS.ContainsKey(c)){
                countS[c]--;
                if(countS[c]<0){
                    return false;
                }

            }else{
                return false;
            }
        }
        return true;
    }
}