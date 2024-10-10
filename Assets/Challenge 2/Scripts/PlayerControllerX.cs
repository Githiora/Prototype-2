using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spwanCoolDown = 1.0f;

    private float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && CanSpawnDog())
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextSpawnTime = Time.time + spwanCoolDown;
        }
    }

    private bool CanSpawnDog()
    {
        return Time.time >= nextSpawnTime;
    }
}
