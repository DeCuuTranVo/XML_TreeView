using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_TreeView.Models;

namespace XML_TreeView.Services
{
    public class XmlTreeViewHandler : IXmlTreeViewHandler
    {
        // Extract XNode list from XML file
        public List<XNode> ExtractNodeList(string pXmlPath)
        {
            // Safety Check
            if (pXmlPath is null)
            {
                throw new ArgumentNullException("The path to XML file can not be null");
            }

            if (!Path.Exists(pXmlPath))
            {
                throw new InvalidOperationException("The specified path does not exist");
            }

            // Read .xml file and create an XNode list
            List<XNode> nodeList = new List<XNode>();

            using (XmlReader reader = XmlReader.Create(pXmlPath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        XNode curNode = new XNode()
                        {
                            ID = reader.GetAttribute("id") ?? String.Empty,
                            Text = reader.GetAttribute("text") ?? String.Empty,
                            Depth = reader.Depth
                        };

                        nodeList.Add(curNode);
                    }
                }
            }

            // Return
            return nodeList;
        }

        // Construct A Tree from the XNode list 
        public XTree ConstructTree(List<XNode> pNodeList)
        {
            // Safety Check
            if (pNodeList is null)
            {
                throw new ArgumentNullException("The list of extracted nodes can not be null");
            }

            // Initialize an XTree
            XNode curNode = null;
            XNode newNode = null;

            XNode rootNode = new XNode() { Depth = -1, Text = "Root Node" };
            XTree xTree = new XTree(rootNode);
            curNode = rootNode;

            // For each XNode in the node list
            foreach (XNode nodeItem in pNodeList)
            {
                newNode = nodeItem;
                // if the new node is a child of the current node, add it to the current node's sub-node list.
                if (newNode.Depth - curNode.Depth == 1)
                {
                    curNode.Nodes.Add(newNode);
                    curNode = newNode;
                }
                // else if the new node is not a child of the current node, move up to the lowest common ancestor node, add it to that node's sub-node list.
                else if (newNode.Depth - curNode.Depth <= 0)
                {
                    int distance = Math.Abs(newNode.Depth - curNode.Depth);

                    for (int i = 0; i < distance + 1; i++)
                    {
                        curNode = (XNode)curNode.Parent;
                    }

                    curNode.Nodes.Add(newNode);
                    curNode = newNode;
                }
                else
                {
                    throw new InvalidOperationException("The child node should never be deeper than two levels compared to the parent node.");
                }
            }

            // Return
            return xTree;
        }

        // Write a function to clone tree
        public XTree CloneTree(XTree xTree)
        {
            // Safety Check
            if (xTree is null)
            {
                throw new ArgumentNullException("The argument tree can not be null.");
            }

            if (xTree.RootNode is null)
            {
                throw new ArgumentNullException("The arguemnt tree's content can not be null.");
            }

            // Shallow copy the RootNode and create a new XTree with that RootNode.
            XNode newNode = (XNode) xTree.RootNode.Clone();
            XTree newTree = new XTree(newNode);

            // Return
            return newTree;
        }
    }
}
