public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        Dictionary<char,char> sTOt =new Dictionary<char,char>();
        Dictionary<char,char> tTOs =new Dictionary<char,char>();
        
        for(int i=0;i<s.Length;i++){
            char sChar=s[i];
            char tChar=t[i];

            if(sTOt.ContainsKey(sChar)){
                if(sTOt[sChar]!=tChar){
                    return false;
                }
            }else{
                sTOt[sChar]=tChar;
            }

            if(tTOs.ContainsKey(tChar)){
                if(tTOs[tChar]!=sChar){
                    return false;
                }
            }else{
                tTOs[tChar]=sChar;
            }
        }
        return true;
        
    }
    
}