using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimimiento : MonoBehaviour
{
    [SerializeField]
    int velocidad = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        //print("horizontal: " + x + " / vertical: " + y);
        transform.Translate(x *Time.deltaTime * velocidad, y* Time.deltaTime * velocidad, 1* Time.deltaTime * velocidad);
    }
}
