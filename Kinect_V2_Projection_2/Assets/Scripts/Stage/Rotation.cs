using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public float zSpeed = 2f;

    float elapsed;

    void Update()
    {
        transform.Rotate(
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
        );

        elapsed += Time.deltaTime;
        if (elapsed < 5f)
        {
            return;
        }

        if (Random.Range(0, 2) == 0)
        {
            xSpeed *= -1f;
        }

        if (Random.Range(0, 2) == 0)
        {
            zSpeed *= -1f;
        }

        elapsed = 0f;
    }
}
