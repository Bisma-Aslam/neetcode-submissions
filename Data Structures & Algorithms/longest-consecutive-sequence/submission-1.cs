public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet=new HashSet<int>(nums);
        int length=0;
        int longest=0;
        foreach(int num in numSet){
            if(!numSet.Contains(num-1)){
                length=1;
                while(numSet.Contains(num+length)){
                    length++;
                }
                longest=Math.Max(longest,length);
            }
        }
        return longest;
    }
}
