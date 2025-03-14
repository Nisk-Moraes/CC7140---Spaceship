using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{

    private float lenght;
    private float movingSpeed = 5f;
    public GameObject cam;
    public float parallaxEffect;

    public static float SLOWMO = 1; // trocar lugar da variavel depois
    
    // Start is called before the first frame update
    void Start()
    {
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }


    // Update is called once per frame
    void Update(){
    transform.position += Vector3.left * Time.deltaTime * movingSpeed * parallaxEffect *  SLOWMO;
    if(transform.position.x < -lenght ) {
        transform.position = new Vector3(lenght, transform.position.y, transform.position.z);
    }
}

}