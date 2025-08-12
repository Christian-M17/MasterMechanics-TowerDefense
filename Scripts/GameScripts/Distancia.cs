using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distancia : MonoBehaviour
{
    public GameObject Distance;
    public Transform RotacaoDistancia;


    // Start is called before the first frame update
    void Start()
    {
        Distance.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RotacaoDistancia.rotation = Quaternion.Euler(0, 0, 0);
    }
    void OnMouseOver()
    {
        Distance.SetActive(true);
    }
    void OnMouseExit()
    {
        Distance.SetActive(false);
    }
}
