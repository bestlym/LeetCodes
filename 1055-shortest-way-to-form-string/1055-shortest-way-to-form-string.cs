public class Solution {
    public int ShortestWay(string source, string target) {
        var counter = 1;
        var i = 0;
        var targetIndex = 0;

        while(targetIndex < target.Length)
        {
            if(!source.Contains(target[targetIndex].ToString()))
            {
                return -1;
            }

            if(i == source.Length)
            {
                counter++;
                i = 0;
            }

            if(source[i] == target[targetIndex])
            {
                targetIndex++;
            }

            i++;
        }

        return counter;
    }
}