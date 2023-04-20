using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.block.Stack;

namespace Assets.block.blocks
{
    internal class EndBlock : ABlock
    {
        public EndBlock(ABlock block) : base(null, block)
        {

        }
        public EndBlock(DataStack stack) : base(stack)
        {

        }
        public override void Connect(ABlock block)
        {
            outputBlocks = new List<ABlock> { block };
        }

        public override void Launch()
        {
            Debug.Log("Код завершён");
        }
    }
}
