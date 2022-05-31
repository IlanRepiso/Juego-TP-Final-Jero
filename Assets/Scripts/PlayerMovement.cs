using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerRotation;
    public bool isTakingDmg;
    public int HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        isTakingDmg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
        transform.Translate(0, 0, PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, PlayerRotation, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -PlayerRotation, 0);
        }
        if (isTakingDmg)
        {
            HealthBar -= 1;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Enemy")
        {
            isTakingDmg = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Enemy")
        {
            isTakingDmg = false;
        }
    }
}
