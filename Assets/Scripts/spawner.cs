using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Pear;
    public Transform spawnPoint;
    public float timeMin;
    public float timeMax;
    public int winCondition;
    float x;
    float timeToGo;
    // Start is called before the first frame update
    void Start()
    {
        timeToGo = Time.fixedTime + Random.Range(timeMin, timeMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime >= timeToGo)
        {
            spawnWaves();
            timeToGo = Time.fixedTime + Random.Range(timeMin, timeMax);
        }
    }

    void spawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(spawnPoint.position.x - 0.5f, spawnPoint.position.x + 0.5f), spawnPoint.position.y, spawnPoint.position.z);
        x += Random.Range(0, 10) * 10;
        transform.rotation = Quaternion.Euler(x, 0, 0);
        int fruit = Random.Range(0, 2);
        GameObject fruitType = (fruit >= 1) ? Apple : Pear;
        Instantiate(fruitType, spawnPosition, transform.rotation);
    }
}
