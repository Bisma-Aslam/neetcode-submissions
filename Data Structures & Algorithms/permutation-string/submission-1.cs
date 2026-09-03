public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char,int> count=new Dictionary<char,int>();
        foreach(char c in s1){
            if(count.ContainsKey(c)){
                count[c]++;
            }else{
                count[c]=1;
            }
        }
        int need=count.Count;
        for(int i=0;i<s2.Length;i++){
            int curr=0;
            Dictionary<char,int> count2=new Dictionary<char,int>();
            for(int j=i;j<s2.Length;j++){
                char c=s2[j];
                if(count2.ContainsKey(c)){
                    count2[c]++;
                }else{
                    count2[c]=1;
                }
                if(!count.ContainsKey(c) || count[c]<count2[c]){
                    break;
                }
                if(count[c]==count2[c]){
                    curr++;
                }
                if(curr==need){
                    return true;
                }
            }
        }
        return false;
    }
}
