public class Solution {
    public bool hasDuplicate(int[] nums) {
        var duplicate = new HashSet<int>();
        foreach(var item in nums){
            if(!(duplicate.Add(item))) return true; 
        }
        return false;
    }
}