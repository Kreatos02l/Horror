using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{

    public float minTime = 0.05f;
    public float maxTime = 1.2f;

    private float timer;
    private Light l;

    void Start()
    {
        l = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            l.enabled = !l.enabled;
            timer = Random.Range(minTime, maxTime);
        }
    }
}
