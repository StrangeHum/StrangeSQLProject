using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.block.Stack;

namespace Assets.block.blocks
{
    internal class StartBlock : ABlock
    {
        public StartBlock(ABlock block) : base(null, block)
        {

        }
        public StartBlock(DataStack stack) : base(stack)
        {

        }

    public override void Connect(ABlock block)
        {
            outputBlocks = new List<ABlock> { block };
        }

        public override void Launch()
        {
            Debug.Log("Старт");
            outputBlocks[0].Launch();
        }
    }
}
