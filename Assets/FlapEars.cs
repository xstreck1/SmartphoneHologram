using UnityEngine;
using System.Collections;

public class FlapEars : MonoBehaviour
{
    float timer = 0f;
    float flap_time = 1.5f;
    bool down = true;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            timer = flap_time;
            Flap();
            down = !down;
        }
    }

    void Flap()
    {
        transform.Translate(down ? Vector3.down : Vector3.up);
    }
}
