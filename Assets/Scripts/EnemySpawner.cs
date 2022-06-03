using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    int i = 5;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (i > 0)
        {
            GameObject clon = Instantiate(Enemy, gameObject.transform.position + gameObject.transform.up + new Vector3(0,i*2,0), Quaternion.Euler(0, 0, 0));

            i -= 1;
        }
    }
}
