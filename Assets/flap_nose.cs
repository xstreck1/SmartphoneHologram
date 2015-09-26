using UnityEngine;
using System.Collections;

public class flap_nose : MonoBehaviour {
    GameObject _ligth_nose;
    GameObject _dark_nose;

    float timer = 0f;
    float speed = 1.5f;

	// Use this for initialization
	void Start () {
        _ligth_nose = transform.FindChild("NoseLight").gameObject;
        _dark_nose = transform.FindChild("NoseDark").gameObject;
        litNose();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime * speed;
        litNose();
    }

    void litNose()
    {
        bool on = (((int)timer) % 2) == 0;
        _ligth_nose.SetActive(on);
        _dark_nose.SetActive(!on);
    }
}
