using UnityEngine;
using System.Collections;

public class foodstuff : MonoBehaviour {
    GameObject tamagochi;
    float timer = 0f;
    float time_to_fall = 1f/3f;

    // Use this for initialization
    void Start () {
        tamagochi = GameObject.Find("tamagochi");
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > time_to_fall)
        {
            timer = 0;
            transform.Translate(Vector3.down);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(this.gameObject);
    }
}
