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
            List<XNode> nodeList = new List<XNode>();

            using (XmlReader reader = XmlReader.Create(pXmlPath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //Console.WriteLine(reader.Name.ToString() + " - " + reader.Depth + " - " + reader.GetAttribute("id") + " - " + reader.GetAttribute("text"));
                        XNode curNode = new XNode()
                        {
                            // Parent
                            ID = reader.GetAttribute("id") ?? String.Empty,
                            Text = reader.GetAttribute("text") ?? String.Empty,
                            Depth = reader.Depth
                        };

                        nodeList.Add(curNode);
                    }
                }
            }

            return nodeList;
        }

        // Construct A Tree from the XNode list 
        public XNode ConstructTree(List<XNode> pNodeList)
        {
            XNode curNode = null;
            XNode newNode = null;

            XNode rootNode = new XNode() { Depth = -1, Text = "Root Node" };
            curNode = rootNode;

            foreach (XNode nodeItem in pNodeList)
            {
                newNode = nodeItem;
                if (newNode.Depth - curNode.Depth == 1)
                {
                    //newNode.Parent = curNode;
                    curNode.Nodes.Add(newNode);
                    curNode = newNode;
                }
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
                    throw new Exception("The child node should never be deep than two level compared to the parent node.");
                }
            }

            return rootNode;

        }

        // Print a tree
        // Reverse a tree
    }
}
