using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyDamage : MonoBehaviour
{
    private int vida = 2;
    public TMP_Text vidatxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida == 0)
        {
            Gerenciador.money += 10;
            Gerenciador.mortos += 1;
            Debug.Log("Mortos:" + Gerenciador.mortos);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala")) {
            vida -= 1;
            vidatxt.text = vida + "/2";
             }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Gerenciador.life -= 10;
            Gerenciador.mortos += 1;
            Debug.Log("Mortos:" + Gerenciador.mortos);
            Destroy(gameObject);
        }


    }
}
