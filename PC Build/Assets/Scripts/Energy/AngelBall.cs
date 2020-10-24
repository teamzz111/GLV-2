using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AngelBall : MonoBehaviour
{
    public Transform target;
    public float angle; 
    public Vector3 direction;
    public TextMeshProUGUI RD;
    public TextMeshProUGUI LVALUE;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = target.position - transform.position;
        angle = Vector3.Angle(Vector3.right, direction);
        RD.text = Mathf.Round(angle).ToString();
        RD.text = RD.text + "º";
        LVALUE.text = Vector3.Distance(target.position, transform.position).ToString();
    }
}
