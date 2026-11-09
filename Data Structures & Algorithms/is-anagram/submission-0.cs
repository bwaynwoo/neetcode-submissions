public class Solution {
    public bool IsAnagram(string s, string t) {
    var sortS = s.ToCharArray();
    var sortT = t.ToCharArray(); 
    Array.Sort(sortS);
    Array.Sort(sortT);
    if(sortS.SequenceEqual(sortT)) return true;
    return false;
    }
}
