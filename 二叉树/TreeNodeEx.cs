namespace 二叉树;

public class TreeNodeEx
{
    public static int TreeNodeCounts(TreeNode? root)
    {
        if (root == null) return 0;
        return 1 + TreeNodeCounts(root.Left) + TreeNodeCounts(root.Right);
    }
}