/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> lista;
    public IList<int> InorderTraversal(TreeNode root) {
        lista = new List<int>();
        recorrer(root);
        return lista;
    }
    
    
    public void recorrer(TreeNode root){
        if(root==null)return; 
        if(root.left!=null);
        recorrer(root.left);
        lista.Add(root.val);
        if(root.right!=null);
        recorrer(root.right);
    }
    
    
    
    
}
