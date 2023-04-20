using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.block
{
    internal class UIBlock: MonoBehaviour
    {
        public LineRenderer lineRenderer;
        public ABlock block;
        public Transform input;
        public Transform output;
        private void Start()
        {
            lineRenderer.startWidth = 0.5f;
            lineRenderer.endWidth = 0.5f;
        }
    }
}
