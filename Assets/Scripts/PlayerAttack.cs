using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject SwordAttack;
    public GameObject PunchAttack;
    public GameObject ScytheAttack;
    public bool Sword;
    public bool Scythe;
    public bool Punch;

    // Start is called before the first frame update
    void Start()
    {
        Sword = true;
        Scythe = false;
        Punch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Sword = true;
            Scythe = false;
            Punch = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Sword = false;
            Scythe = true;
            Punch = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Sword = false;
            Scythe = false;
            Punch = true;
        }
        if (Sword == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("hi");
                GameObject clon = Instantiate(SwordAttack, gameObject.transform.position+ gameObject.transform.forward, Quaternion.Euler(0,0,0), transform);
                Destroy(clon, 1);
            }
        }
        else if (Scythe == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clon = Instantiate(ScytheAttack, gameObject.transform.position + gameObject.transform.forward, Quaternion.Euler(0, 0, 0), transform);
                Destroy(clon, 1);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clon = Instantiate(PunchAttack, gameObject.transform.position + gameObject.transform.forward, Quaternion.Euler(0, 0, 0), transform);
                Destroy(clon, 1);
            }
        }
    }
}
