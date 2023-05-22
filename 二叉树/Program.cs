using 二叉树;

var root = new TreeNode
{
    Left = new TreeNode(),
    Right = new TreeNode()
};

root.Left.Left = new TreeNode();
root.Right.Right = new TreeNode();

var count = TreeNodeEx.TreeNodeCounts(root);
Console.WriteLine(count);
Console.ReadLine();