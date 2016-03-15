using UnityEngine;
using System.Collections;

public class ParticlesTest : MonoBehaviour {

    public ParticleSystem part;
    private TextManager textManager;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        textManager = GameObject.Find("Canvas").GetComponent<TextManager>();
    }

    void OnParticleCollision(GameObject col)
    {
        if(col.gameObject.tag == "Player")
        {
           // Rigidbody rb = col.GetComponent<Rigidbody>();
           // rb.velocity = Vector3.zero;
           // rb.angularVelocity = Vector3.zero;
            if(textManager.state == 1)
            {
                textManager.state = 3;
            }
        }
    }
}