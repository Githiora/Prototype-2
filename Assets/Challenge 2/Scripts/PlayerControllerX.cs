using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeInterval = 1.0f;
    private float prevTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (prevTime == 0 || ((Time.time - prevTime) > timeInterval)))
        {

            prevTime = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
