public class Solution{
    public int FindMaxConsecutiveOnes(int[] nums){
        int Maxres=0;
        int count=0;
        foreach(int num in nums){
            if(num==0){
                Maxres=Math.Max(Maxres,count);
                count=0;
            }else{
                count++;
            }
        }
        return Math.Max(Maxres,count);
    }
}