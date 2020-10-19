using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    int GiroZ = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, GiroZ);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //(Collision.Name);
        if (collision.tag == "pikup") Destroy(collision.gameObject);
    }
}
