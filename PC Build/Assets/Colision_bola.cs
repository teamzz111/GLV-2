using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;

public class Colision_bola : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto1;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "table")
        {
            double t = 41.06;
            var c = this.gameObject.transform.position;
            
            string D = "0";
            if ((c.x - t) > 0)
                D = (((c.x - t) * 10).ToString("F1"));
            else
                D = (((c.x - t) * -10).ToString("F1"));

            texto.text = (double.Parse(D) + double.Parse(texto1.text)).ToString() + "cm";
            Destroy(this.GetComponent<Colision_bola>());
        }
    }
}





