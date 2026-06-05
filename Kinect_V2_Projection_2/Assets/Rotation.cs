using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public float zSpeed = 2f;
    public float time = 0; 
    // Start is called before the first frame update
    void Start()
    {
    }

// Update is called once per frame
void Update()
    {
        transform.Rotate(
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
       );
       time += Time.deltaTime;
       if (time > 5) {
            int random = Random.Range(0, 2);
            if (random == 0)
                xSpeed *= -1;
            //random = Random.Range(0, 2);
            //if (random == 0)
                //ySpeed *= -1;
            random = Random.Range(0, 2);
            if (random == 0)
                zSpeed *= -1;

            time = 0;
        }
    }
}
