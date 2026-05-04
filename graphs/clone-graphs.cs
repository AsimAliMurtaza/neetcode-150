/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> cloned = new Dictionary<Node, Node>();
    
    public Node CloneGraph(Node node) {


        if (node == null){
            return null;
        }

        if(cloned.ContainsKey(node)){
            return cloned[node];
        }

        Node clone = new Node(node.val);

        cloned[node] = clone;

        foreach(var n in node.neighbors){
            clone.neighbors.Add(CloneGraph(n));
        }
        
        return clone;
    }
}
