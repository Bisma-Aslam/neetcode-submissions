public class Solution {
    int res=0;
    public int CountCharacters(string[] words, string chars) {
        Dictionary<char,int> charCount=new Dictionary<char,int>();
        foreach(char c in chars){
            if(!charCount.ContainsKey(c)) charCount[c]=0;
            charCount[c]++;
        }
        
        foreach(string w in words){
            Dictionary<char,int> charWord=new Dictionary<char,int>();
            foreach(char c in w){
                if(!charWord.ContainsKey(c)) charWord[c]=0;
                charWord[c]++;
            }
            bool good=true;
            foreach(var kvp in charWord){
                int avaiable=charCount.ContainsKey(kvp.Key)?charCount[kvp.Key]:0;
                if(kvp.Value>avaiable){
                    good=false;
                    break;
                } 
            }
            if(good){
                    res+=w.Length;
                }
        }
     
        return res;
    }
}