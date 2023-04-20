using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.block.Stack;

namespace Assets.block
{
    internal abstract class ABlock
    {
        DataStack stack;
        public List<ABlock> outputBlocks;
        public ABlock(DataStack stack, params ABlock[] outputs)
        {
            outputBlocks = new List<ABlock>(outputs);
            this.stack = stack;
        }
        public ABlock(DataStack stack)
        {
            outputBlocks = new List<ABlock>(1);
            this.stack = stack;
        }
        public abstract void Connect(ABlock block);
        public abstract void Launch();
        public void CreateValue(string name, string value, typeUData type)
        {
            stack.AddToStack(new uType(value, type), name);
        }
    }
}
