using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace Assets.block
{
    internal class BlockConector : MonoBehaviour
    {
        UIBlock blockIn;
        UIBlock blockOut;

        public void TryConnect()
        {
            if (blockIn == null)
            {
                return;
            }

            if(blockOut == null)
            {
                return;
            }
            //blockIn.lineRenderer.SetPosition(0, GetWorldCord(blockIn.input.transform.position));
            //blockIn.lineRenderer.SetPosition(1, GetWorldCord(blockOut.output.transform.position));
            blockIn.lineRenderer.SetPosition(0, blockIn.input.transform.position);
            blockIn.lineRenderer.SetPosition(1, blockOut.output.transform.position);
            Debug.Log(GetWorldCord(blockIn.input.transform.position).ToString());
            Debug.Log(GetWorldCord(blockOut.output.transform.position).ToString());
            Debug.Log("Соединение");
            blockIn = null;
            blockOut = null;
            //blockIn.block.Connect(blockOut);
        }
        private Vector2 GetWorldCord(Vector3 mousePos)
        {
            Vector2 mousePoint = new Vector2(mousePos.x, mousePos.y);
            return Camera.main.ScreenToWorldPoint(mousePoint);
        }
        public void ButtonInp(UIBlock block)
        {
            if(blockIn == null)
            {
                blockIn = block;
            }
            TryConnect();
        }
        public void ButtonOut(UIBlock block)
        {
            if (blockOut == null)
            {
                blockOut = block;
            }
            TryConnect();
        }
    }
}
