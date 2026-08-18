public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string,int> count=new Dictionary<string,int>();
        foreach(string s in arr){
            if(count.ContainsKey(s)){
                count[s]++;
        }else{
            count[s]=1;
        }
        }
        foreach(string s in arr){
            if(count[s]==1){
                k--;
                if(k==0){
                return s;
            }
            }
            
        }
       
    return ""  ;
    }
}