using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePoint : MonoBehaviour
{
    public LineRenderer line;
    private void Start()
    {
        line.startWidth = .2f;
        line.endWidth = .2f;
        line.positionCount = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 vector2 = GetWorldCord(Input.mousePosition);
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, vector2);
        }
    }

    private Vector2 GetWorldCord(Vector3 mousePos)
    {
        Vector2 mousePoint = new Vector2(mousePos.x, mousePos.y);
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
