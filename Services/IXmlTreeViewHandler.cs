﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_TreeView.Models;

namespace XML_TreeView.Services
{
    public interface IXmlTreeViewHandler
    {
        public List<XNode> ExtractNodeList(string pXmlPath);

        public XNode ConstructTree(List<XNode> pNodeList);
    }
}