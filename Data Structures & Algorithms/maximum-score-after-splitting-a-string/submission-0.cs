public class Solution{
    public int MaxScore(string s){
        int res=0;
        int n=s.Length;
        for(int i=1;i<n;i++){
            int leftZero=0;
            int rightOne=0;
            for(int j=0;j<i;j++){
                if(s[j]=='0'){
                    leftZero++;
                }
            }
            for(int j=i;j<n;j++){
               if(s[j]=='1'){
                rightOne++;
               }
            }
            res=Math.Max(res,leftZero+rightOne);
        }
        return res;
    }
}