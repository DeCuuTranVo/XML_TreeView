using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_TreeView.Models;

namespace XML_TreeView
{
    public static class XmlTreeViewConverter
    {
        public static List<XNode> ExtractNodeList(string pXmlPath)
        {
            List<XNode> nodeList = new List<XNode>();

            using (XmlReader reader = XmlReader.Create(pXmlPath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        //switch (reader.Name.ToString())
                        //{
                        //    case "Name":
                        //        Console.WriteLine("Name of the Element is : " + reader.ReadString());
                        //        break;
                        //    case "Location":
                        //        Console.WriteLine("Your Location is : " + reader.ReadString());
                        //        break;
                        //}

                        //Console.WriteLine(reader.Name.ToString() + " - " + reader.Depth + " - " + reader.GetAttribute("id") + " - " + reader.GetAttribute("text"));
                        XNode curNode = new XNode()
                        {
                            // Parent
                            ID = reader.GetAttribute("id"),
                            Text = reader.GetAttribute("text"),
                            Depth = reader.Depth
                        };

                        nodeList.Add(curNode);
                    }
                    //Console.WriteLine("");
                }
            }

            return nodeList;
        }

        public static XNode ConstructTree(List<XNode> pNodeList)
        {
            XNode curNode = null;
            XNode newNode = null;

            XNode rootNode = new XNode() {Depth = -1, Text="Root Node" };
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
    }

}
