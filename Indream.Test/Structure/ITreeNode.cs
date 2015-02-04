using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Test.Structure
{
    public interface ITreeNode<T> : IStructure
    {
        ITreeNode<T> LeftChild { get; set; }

        ITreeNode<T> RightChild { get; set; }
    }
}
