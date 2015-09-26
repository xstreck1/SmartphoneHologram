using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void MoveRight ()
    {
        if (transform.position.x > -2f)
        {
            transform.Translate(Vector3.left);
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x < 2f)
        {
            transform.Translate(Vector3.right);
        }
    }
}
