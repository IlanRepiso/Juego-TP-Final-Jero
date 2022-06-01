using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    float PlayerSpeed = 0.5f;
    float PlayerRotation = 7.5f;
    bool isTakingDmg;
    bool isAlive;
    public int HealthBar = 100;

    // Start is called before the first frame update
    void Start()
    {
        isTakingDmg = false;
        isAlive = true;
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
        if (HealthBar > 0)
        {
            isAlive = true;
        }
        if (HealthBar < 1)
        {
            isAlive = false;
        }
        if (isAlive == false)
        {
            SceneManager.LoadScene("Gameplay");
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
