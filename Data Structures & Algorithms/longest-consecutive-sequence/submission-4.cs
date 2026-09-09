public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest=0;
        int length=0;
        foreach(int num in nums){
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
