public class Solution{
    public int NumUniqueEmails(string[] emails){
        HashSet<string> unique=new HashSet<string>();
        foreach(string email in emails){
            string[] parts =email.Split("@");
            string local=parts[0];
            string domain=parts[1];
            local=local.Split("+")[0];
            local=local.Replace(".","");
            unique.Add(local + "@" + domain);
        }
        return unique.Count;
    }
}