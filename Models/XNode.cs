using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_TreeView.Models
{
    public class XNode : TreeNode
    {
        public string ID { get; set; } = string.Empty;

        public int Depth { get; set;} = 0;
    }
}
