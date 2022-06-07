using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    int i = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (i > 0)
        {
            GameObject clon = Instantiate(Enemy, gameObject.transform.position + new Vector3(i*2, 0, 0), Quaternion.Euler(0, 0, 0), transform);
            i -= 1;
        }
    }
}
