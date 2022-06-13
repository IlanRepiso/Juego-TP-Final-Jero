using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    bool isTakingDmg;
    bool isAlive;
    public int healthBar = 100;
    public Text health;

    // Start is called before the first frame update
    void Start()
    {
        isTakingDmg = false;
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        health.text = healthBar.ToString(); 
        if (isTakingDmg)
        {
            healthBar -= 3;
        }
        if (healthBar > 0)
        {
            isAlive = true;
        }
        if (healthBar < 1)
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
        if (other.gameObject.tag == "Enemy")
        {
            isTakingDmg = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            isTakingDmg = false;
        }
    }
}

