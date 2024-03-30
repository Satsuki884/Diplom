using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollClamp : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float minClampY;
    public float maxClampY;

    private void Update()
    {
        Vector3 pos = scrollRect.content.localPosition;
        pos.y = Mathf.Clamp(pos.y, minClampY, maxClampY);
        scrollRect.content.localPosition = pos;
    }
}
