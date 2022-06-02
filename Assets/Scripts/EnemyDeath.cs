using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject SwordAttack;
    public GameObject PunchAttack;
    public GameObject ScytheAttack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "PunchAttack" || other.gameObject.name == "ScytheAttack" || other.gameObject.name == "SwoedAttack")
        {
            Destroy (this);
        }
    }
}
