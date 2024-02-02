using System;
using System.Windows.Forms;

namespace Tarefa.Cenario01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildTree(int[] array)
        {
            TreeNode root = BuildSubTree(array, 0, array.Length - 1);
            if (root != null)
            {
                treeView1.Nodes.Add(root);
            }
        }

        private TreeNode BuildSubTree(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            int maxIndex = FindMaxIndex(array, start, end);
            TreeNode root = new TreeNode(array[maxIndex].ToString());

            TreeNode leftSubTree = BuildSubTree(array, maxIndex + 1, end);
            if (leftSubTree != null)
            {
                root.Nodes.Add(leftSubTree); // Galhos da esquerda
            }

            TreeNode rightSubTree = BuildSubTree(array, start, maxIndex - 1);
            if (rightSubTree != null)
            {
                root.Nodes.Add(rightSubTree);   // Galhos da direita
            }

            return root;
        }

        private int FindMaxIndex(int[] array, int start, int end)
        {
            int maxIndex = start;
            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] inputArray = { 3, 2, 1, 6, 0, 5 };

            BuildTree(inputArray);
        }
    }
}
