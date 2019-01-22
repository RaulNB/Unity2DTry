using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    float timer;
    public GameObject firePrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2f)
        {
            timer = 0;
            float x = Random.Range(-100f, 100f);
            float y = Random.Range(0f, 50f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(firePrefab, position, rotation);
        }
    }
}
