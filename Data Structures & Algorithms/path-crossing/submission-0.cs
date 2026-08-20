public class Solution {
    public bool IsPathCrossing(string path) {
        int x=0;
        int y=0;

        HashSet<string> visited=new HashSet<string>();
        visited.Add(x +","+ y);
        foreach(char direction in path){
            if(direction=='N') 
            {
                y++;
            }
            else if(direction=='S') 
            {
                y--;
            }
            else if(direction=='E') 
            {
                x++;
            }
            else if(direction=='W') 
            {
                x--;
            }
            
            string position=x +","+ y;
            if(visited.Contains(position)){
                return true;
            }else{
                visited.Add(position);
            }
            
        }
        return false;
        
    }
}