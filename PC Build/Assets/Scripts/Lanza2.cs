using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lanza2 : MonoBehaviour
{
    private Vector3 mOffset;
    public TextMeshProUGUI RD;

   /* void OnMouseDown()

    {
        double t = 41.06;
        var c = this.transform.position;
        double x = (double)c.x;
        texto.text = ((x-t).ToString());
    }*/
    void OnMouseDrag()

    {
        double t = 41.06;
        var c = this.transform.position;
        double x = (double)c.x;
        if((x-t)>0)
            RD.text = (((x - t)*10).ToString("F1"));
        else
            RD.text = (((x - t)*-10).ToString("F1"));
    }
}
