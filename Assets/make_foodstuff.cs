using UnityEngine;
using System.Collections;

public class make_foodstuff : MonoBehaviour {
    float timer = 0f;
    GameObject foodstuff;

    // Use this for initialization
    void Start () {
        foodstuff = Resources.Load("foodObject") as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            timer = Random.Range(1f, 4f);

            Vector3 position = new Vector3(Random.Range(3, 5) * (Random.Range(0, 2) == 0 ? 1 : -1), 10f, 0f);
            Instantiate(foodstuff, position, Quaternion.identity);
        }
    }
}
