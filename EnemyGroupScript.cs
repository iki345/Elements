using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroupScript : MonoBehaviour
{
    private float interval;
    private float time = 0f;
    public float minTime = 10f;
    public float maxTime = 30f;
    public EnemySpawnScript point1;
    [Header("Set X Position Min and Max")]
    [Range(-100f, 0f)]
    public float xMinPosition = -5f;
    [Range(0f, 100f)]
    public float xMaxPosition = 5f;
    [Header("Set Z Position Min and Max")]
    [Range(-100f, 0f)]
    public float zMinPosition = -5f;
    [Range(0f, 100f)]
    public float zMaxPosition = 5f;

    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            transform.position = GetRandomPosition();
            point1.SpawnEnemy();
            time = 0f;
            interval = GetRandomTime();
        }
    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = 0;
        float z = Random.Range(zMinPosition, zMaxPosition);

        return new Vector3(x, y, z);
    }
}