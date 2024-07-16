using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] Material material;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnEnemy()
    {
        GameObject o;

        o = Instantiate(cube, transform.position, Quaternion.identity);

        o.GetComponent<Renderer>().material = material;
    }
}