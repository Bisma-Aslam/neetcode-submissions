public class Solution {
    public int MaxDifference(string s) {
        int[] freq=new int[26];
        foreach(char c in s ){
            freq[c-'a']++;
        }
        int maxOdd=0;
        int minEven=int.MaxValue;
        foreach(int count in freq) {
            if(count==0){
                continue;
            }
            if(count%2!=0){
                maxOdd=Math.Max(maxOdd,count);
            }else{
                minEven=Math.Min(minEven,count);
            }
        }
        return maxOdd-minEven;
        
    }
}