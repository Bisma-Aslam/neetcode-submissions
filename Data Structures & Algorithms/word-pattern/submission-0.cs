public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words=s.Split(" ");

        if(pattern.Length!=words.Length){
            return false;
        }

        Dictionary<char,string> cTOw =new Dictionary<char,string>(); 
        Dictionary<string,char> wTOc=new Dictionary<string,char>();
        for(int i=0;i<pattern.Length;i++){
            char c=pattern[i];
            string w=words[i];
            if(cTOw.ContainsKey(c) && cTOw[c]!=w){
                return false;
            }
        if(wTOc.ContainsKey(w) && wTOc[w]!=c)
        {
            return false;
        }
        cTOw[c]=w;
        wTOc[w]=c;
        }
        return true;
        
    }
}