using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.block.Stack;

namespace Assets.block.blocks
{
    internal class IfBlock : ABlock
    {
        public IfBlock(ABlock block) : base(null, block)
        {

        }
        public IfBlock(DataStack stack) : base(stack)
        {

        }
        public override void Connect(ABlock block)
        {
            outputBlocks = new List<ABlock> { block };
        }

        public override void Launch()
        {
            Debug.Log("Условия");
            outputBlocks[0].Launch();
        }
    }
}
