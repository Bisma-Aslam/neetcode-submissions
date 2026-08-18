public class Solution {
    public int CountSeniors(string[] details) {
        int count=0;
        foreach(string passenger in details){
            string age=passenger.Substring(11,2);
            int ageNum=int.Parse(age);
            if(ageNum>60){
                count++;
            }

        }
        return count;
    }
}