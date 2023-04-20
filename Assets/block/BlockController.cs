using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.block.Stack;
using Assets.block.blocks;

namespace Assets.block
{
    internal class BlockController : MonoBehaviour
    {
        public DataStack stack;

        List<ABlock> _blocks;

        private void Start()
        {
            stack = new DataStack();
            _blocks = new List<ABlock>(4)
            {
                new StartBlock(stack),
                new InpOutBlock(stack, TypeBlock.Out),
                new InpOutBlock(stack, TypeBlock.Inp),
                new EndBlock(stack)
            };
            for (int i = 0; i < _blocks.Count - 1; i++)
            {
                _blocks[i].Connect(_blocks[i+1]);
            }
            //Launch();
        }
        /// <summary>
        /// Присоеденение одного блока к другому
        /// </summary>
        /// <param name="aBlock"></param>
        /// <param name="bBlock"></param>
        void ConnectBTB(ABlock aBlock, ABlock bBlock)
        {
            //aBlock.co
        }
        /// <summary>
        /// Создание блока
        /// </summary>
        /// <param name="block"></param>
        public void CreateBlock(ABlock block)
        {
            _blocks.Add(block);
        }
        /// <summary>
        /// Запуск кода
        /// </summary>
        public void Launch()
        {
            _blocks[0].Launch();
        }
    }
}
