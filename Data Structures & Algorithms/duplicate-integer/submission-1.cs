public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool isDuplicate=false;
        Dictionary<int,int> count=new Dictionary<int,int>();
        foreach(int n in nums){
            if(count.ContainsKey(n)){
                isDuplicate=true;
                count[n]++;
            }else{
                count[n]=1;
            }

        }
        return isDuplicate;
        
    }
}