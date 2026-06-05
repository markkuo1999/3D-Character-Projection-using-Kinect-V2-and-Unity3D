using UnityEngine;

public class Change_Color : MonoBehaviour
{
    public Light myLight;

    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    public bool repeatColor = false;

    float startTime;

    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    void Update()
    {
        if (!changeColors || myLight == null)
        {
            return;
        }

        float elapsed = Time.time - startTime;
        float t = repeatColor
            ? Mathf.PingPong(elapsed * colorSpeed, 1f)
            : Mathf.Clamp01(elapsed * colorSpeed);

        myLight.color = Color.Lerp(startColor, endColor, t);
    }
}
