using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Transform BalaTransform;
    public Rigidbody BalaRigidBody;
    public Transform pontoReferencia;
    public float velocidade;
    void Start()
    {

        BalaTransform.LookAt(pontoReferencia);
        BalaRigidBody.velocity = new Vector3(transform.forward.x * velocidade, 0, transform.forward.z * velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            pontoReferencia = GameObject.FindWithTag("Enemy").transform;

        }
        catch
        {

            Destroy(gameObject);
        }
        if (BalaTransform.position.x > 100 || BalaTransform.position.z > 100 || BalaTransform.position.y < -100 || BalaTransform.position.y > 100)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
    }
}
