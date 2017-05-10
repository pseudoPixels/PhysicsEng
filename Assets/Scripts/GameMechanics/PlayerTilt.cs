using UnityEngine;
using System.Collections;

public class PlayerTilt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, GetComponent<Rigidbody2D>().velocity.y, 0.0f);
        //rigidbody2D.velocity = movement * 10.0f;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(moveHorizontal, 0));

        Debug.Log("Tilt");
    }
}
