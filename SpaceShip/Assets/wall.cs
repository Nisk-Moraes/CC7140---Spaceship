using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
