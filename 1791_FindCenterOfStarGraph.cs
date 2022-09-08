public class Solution {
    public int FindCenter(int[][] edges) {
        if(edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            return edges[0][0];
        return edges[0][1];
    }
}

// Explination 

// We only need to check of the repeating memeber in the two first tuble
// First we check if the first element in the first tuple exist in the second tuple
// if not, then it must be the second element, no need to check