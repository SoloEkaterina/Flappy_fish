using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime;

    public Spawner(float queueTime)
    {
        this.queueTime = queueTime;
    }

    private float time = 0;
    public GameObject obstacle;

    public float height;

    // Update is called once per frame
    void Update()
    {
        if(time > queueTime)
        {
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 10);

        }

        time += Time.deltaTime;
    }
}
