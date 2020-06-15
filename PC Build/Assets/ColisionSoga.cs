using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;

public class ColisionSoga : MonoBehaviour
{
  public TextMeshProUGUI texto;
private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "cuerda")
        {
            var c = other.gameObject.transform.position;
            texto.text = ((c.y)*10).ToString("F1") + "cm";
            Destroy(other.gameObject);
            Destroy(this.GetComponent<ColisionSoga>());
        }
    }
}
