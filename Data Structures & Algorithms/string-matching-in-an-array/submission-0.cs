public class Solution {
    public List<string> StringMatching(string[] words) {
        List<string> result=new List<string>();
        foreach(string word in words){
            foreach(string others in words){
                if(word!=others && others.Contains(word)){
                    result.Add(word);
                    break;
                }
            }

        }
        return result;
    }
}