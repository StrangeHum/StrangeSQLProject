using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.block.Stack;

namespace Assets.block.blocks
{
    internal class InpOutBlock : ABlock
    {
        TypeBlock type;
        

        public InpOutBlock(ABlock block) : base(null, block)
        {

        }
        public InpOutBlock(DataStack stack, TypeBlock type) : base(stack)
        {
            this.type = type;
        }
        public override void Connect(ABlock block)
        {
            outputBlocks = new List<ABlock> { block };
        }

        public override void Launch()
        {
            if(type == TypeBlock.Inp)
            {
                //CreateValue();
                Debug.Log("Inp");
            }
            else
            {
                Debug.Log("Out");
            }
            Debug.Log("ИнАутП");
            outputBlocks[0].Launch();
        }
    }
    internal enum TypeBlock
    {
        Inp,
        Out
    }
}
