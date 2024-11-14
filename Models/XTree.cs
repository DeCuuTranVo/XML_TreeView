using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;

namespace XML_TreeView.Models
{
    public class XTree
    {
        public XNode RootNode { get; set; } = new XNode() { Depth = -1, Text = "Root Node" };

        public XTree(XNode pRootNode) {
            RootNode = pRootNode;
        }

        public XTree()
        {

        }

        // Reverse Tree
        public void Reverse()
        {
            //Console.WriteLine("Start Reversing Tree");
            //RootNode = ReverseSubTree(RootNode);

            foreach (var item in RootNode.Nodes)
            {
                ReverseSubTree((XNode)item);
            }
        }

        private XNode ReverseSubTree(XNode xNode)
        {
            if (xNode is null)
            {
                return null;
            }

            if (xNode.Nodes.Count == 0)
            {
                return xNode;
            }

            foreach (var item in xNode.Nodes)
            {
                ReverseSubTree((XNode)item);
            }

            // swap the children
            List<XNode> subNodeList = new List<XNode>();

            foreach (var item in xNode.Nodes)
            {
                subNodeList.Add((XNode)item);
            }

            subNodeList.Reverse();
            xNode.Nodes.Clear();

            foreach (var item in subNodeList)
            {
                xNode.Nodes.Add(item);
            }

            return xNode;
        }

        // Sort Tree by Text field
        public void Sort(SortOrder sortOrder)
        {
            foreach (var item in RootNode.Nodes)
            {
                SortSubTree((XNode)item, sortOrder);
            }
        } 

        private XNode SortSubTree(XNode xNode, SortOrder sortOrder)
        {
            if (xNode is null)
            {
                return null;
            }

            if (xNode.Nodes.Count == 0)
            {
                return xNode;
            }

            foreach (var item in xNode.Nodes)
            {
                ReverseSubTree((XNode)item);
            }

            // swap the children
            List<XNode> subNodeList = new List<XNode>();

            foreach (var item in xNode.Nodes)
            {
                subNodeList.Add((XNode)item);
            }

            if (sortOrder == SortOrder.Ascending)
            {
                subNodeList = subNodeList.OrderBy(x => x.Text).ToList();
            }
            else if (sortOrder == SortOrder.Descending)
            {
                subNodeList = subNodeList.OrderByDescending(x => x.Text).ToList();
            }
            
            xNode.Nodes.Clear();

            foreach (var item in subNodeList)
            {
                xNode.Nodes.Add(item);
            }

            return xNode;
        }

        // Print Tree
        public void Print()
        {         
            foreach (XNode item in RootNode.Nodes)
            {
                PrintTree(item, "", true);
            }
        }

        // Pre-order Traversal
        private void PrintTree(XNode tree, String indent, bool last)
        {
            Console.WriteLine(indent + "+- " + tree.Text);
            indent += last ? "   " : "|  ";

            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                PrintTree((XNode) tree.Nodes[i], indent, i == tree.Nodes.Count - 1);
            }
        }


    }
}
