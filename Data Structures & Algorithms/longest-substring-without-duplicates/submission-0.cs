public class Solution{
    public int LengthOfLongestSubstring(string s){
        Dictionary<char,int> count=new Dictionary<char,int>();
        int l=0;
        int res=0;
        for(int i=0;i<s.Length;i++){
            if(count.ContainsKey(s[i])){
                l=Math.Max(count[s[i]]+1,l);
            }
            count[s[i]]=i;
            res=Math.Max(res,i-l+1);
        }
        return res;
    }
}