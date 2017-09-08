using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realytics_Test
{
    class Node
    {
        #region Private
        private int number;

        private Node left;

        private Node right;

        private Node parent;
        #endregion

        #region Properties
        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }

        public Node Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public Node Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }

        public Node Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }
        #endregion

        #region Constructor
        public Node()
        {

        }
        #endregion

        #region Methods
        public string Serialize(Node node)
        {
            string path = "";
            string children = "";

            if (node.Left != null)
            {
                path = node.Number + Serialize(node.Left);
            }
            else
            {
                children = node.Number + ".";
            }

            if (node.Right != null)
            {
                path = path + children + Serialize(node.Right);
                return path;
            }
            else
            {
                return children + ".";
            }
        }
        #endregion
    }
}
