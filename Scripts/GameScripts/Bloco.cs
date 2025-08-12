using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    private Renderer _renderer;
    public Transform PosicaoGerador;
    public GameObject[] Torretas;
    private bool ativo = false;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        Debug.Log("Clicked");
        verificarTorre(Gerenciador.pativo);

    }

    private void verificarTorre(int valor)
    {
        switch (valor)
        {
            case 0:
                if (ativo == false)
                {
                    if (Gerenciador.money >= 100)
                    {
                        Gerenciador.money -= 100;
                        _renderer.material.color = Color.green;
                        Instantiate(Torretas[valor], PosicaoGerador.position + new Vector3(0, 1, 0), PosicaoGerador.rotation);
                        ativo = true;
                    }
                }
               break;
            case 1:
                if (ativo == false)
                {
                    if (Gerenciador.money >= 100)
                    {
                        Gerenciador.money -= 100;
                        _renderer.material.color = Color.green;
                        Instantiate(Torretas[valor], PosicaoGerador.position + new Vector3(0, 1, 0), PosicaoGerador.rotation);
                        ativo = true;
                    }
                }
                break;
            case 2:
                if (ativo == false)
                {
                    if (Gerenciador.money >= 60)
                    {
                        Gerenciador.money -= 60;
                        _renderer.material.color = Color.green;
                        Instantiate(Torretas[valor], PosicaoGerador.position + new Vector3(0, 1, 0), PosicaoGerador.rotation);
                        ativo = true;
                    }
                }
                break;
            case 3:
                if (ativo == true)
                {
                    // Encontrar o objeto mais próximo com a tag "torre"
                    GameObject[] torres = GameObject.FindGameObjectsWithTag("torre");
                    GameObject torreMaisProxima = null;
                    float menorDistancia = Mathf.Infinity;

                    foreach (GameObject torre in torres)
                    {
                        float distancia = Vector3.Distance(torre.transform.position, PosicaoGerador.position);
                        if (distancia < menorDistancia)
                        {
                            menorDistancia = distancia;
                            torreMaisProxima = torre;
                        }
                    }

                    if (torreMaisProxima != null)
                    {
                        Destroy(torreMaisProxima);
                        Gerenciador.money += 50;
                        _renderer.material.color = Color.white;
                        ativo = false;
                    }
                }
                break;
            default: break;
        }
    }

}
