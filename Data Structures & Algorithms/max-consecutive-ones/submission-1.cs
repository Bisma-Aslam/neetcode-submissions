public class Solution{
    public int FindMaxConsecutiveOnes(int[] nums){
        int maxCount=0;
        int count=0;
        foreach(int num in nums){
            if(num==0){
                maxCount=Math.Max(maxCount,count);
                count=0;
            }else{
                count++;
            }
        }
        return Math.Max(maxCount,count);
    }
}