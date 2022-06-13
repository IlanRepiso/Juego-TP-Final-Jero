using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject Enemy;
    int i = 3;
    float timer = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            while (i > 0)
            {
                GameObject clon = Instantiate(Enemy, gameObject.transform.position + new Vector3(i * 2, 0, 0), Quaternion.Euler(0, 0, 0), transform);
                i -= 1;
            }
        }
    }
}
