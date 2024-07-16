using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    private float interval;
    private float time = 0f;
    public EnemySpawnScript point1;
    public EnemySpawnScript point2;
    public EnemySpawnScript point3;
    [SerializeField] int maxNumOfEnemys; //敵スポーン上限
    private int numberOfEnemys;
    [Header("Set X Position Min and Max")] //敵スポーン範囲の指定,x
    [Range(-100f, 0f)]
    public float xMinPosition = -100f;
    [Range(0f, 100f)]
    public float xMaxPosition = 100f;
    [Header("Set Z Position Min and Max")] //敵スポーン範囲の指定,y
    [Range(-100f, 0f)]
    public float zMinPosition = -100f;
    [Range(0f, 100f)]
    public float zMaxPosition = 100f;

    // Start is called before the first frame update
    void Start()
    {
        interval = 2f; //敵スポーンの間隔
        numberOfEnemys = 0; //敵スポーン上限の変数
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 10)
        {
            numberOfEnemys--;
        }

        if (numberOfEnemys >= maxNumOfEnemys)
        {
            return;
        }           

        if (time > interval)
        {
         transform.position = GetRandomPosition();
            switch (Random.Range(0, 3))
            {
                case 0:
                    point1.SpawnEnemy();
                    break;
                case 1:
                    point2.SpawnEnemy();
                    break;
                case 2:
                    point3.SpawnEnemy();
                    break;
            }
            numberOfEnemys++;
            time = 0f;
        }
    }
    private Vector3 GetRandomPosition()
    {       
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = 0;
        float z = Random.Range(zMinPosition, zMaxPosition);

        return new Vector3(x,y,z);
    }
}
