using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inimigoPrefab;    // Prefab do projétil


    void Start()
    {
        float waitTime = Random.Range(0f, 5f);
        yield return new WaitForSeconds(waitTime);

        // Instanciar o projétil no Firee e adicionar força para ele se mover para cima
        GameObject inimigo = Instantiate(inimigoPrefab, gameObject.position, Quaternion.identity);
        Rigidbody2D rbInimigo = inimigo.GetComponent<Rigidbody2D>();
        rbInimigo.velocity = Vector2.right * inimigoSpeed * paralax.SLOWMO * -1f;  // Movimenta o projétil para o lado
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
