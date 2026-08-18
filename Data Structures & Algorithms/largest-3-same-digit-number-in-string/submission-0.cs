public class Solution{
    public string LargestGoodInteger(string num){
        string res="";
        int val=0;

        for(int i=0;i<num.Length-2;i++){
            if(num[i]==num[i+1] && num[i]==num[i+2]){
                string tmp=num.Substring(i,3);
                int tmpVal=int.Parse(tmp);
                if(val<=tmpVal){
                    val=tmpVal;
                    res=tmp;
                }
            }

        }
        return res;
    }
}