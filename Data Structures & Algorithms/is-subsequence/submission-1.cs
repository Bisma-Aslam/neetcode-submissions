public class Solution{
    public bool IsSubsequence(string s,string t){
       return rec(0,0,s,t);
    }
    public bool rec(int i,int j,string s,string t){
        if(i==s.Length){
            return true;
        }
        if(j==t.Length){
            return false;
        }
        if(s[i]==t[j]){
            return rec(i+1,j+1,s,t);
        }
        return rec(i,j+1,s,t);
    }
}