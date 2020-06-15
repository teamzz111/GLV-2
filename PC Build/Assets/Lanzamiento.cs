using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lanzamiento : MonoBehaviour
{
    public TextMeshProUGUI texto;
    void Update()
    {
        var fwdSpeed = Vector3.Dot(this.GetComponent<Rigidbody>().velocity, transform.forward);
        texto.text = fwdSpeed.ToString();
        if(fwdSpeed<0)
        {
            Destroy(this.GetComponent<Lanzamiento>());
        }
    }
}
