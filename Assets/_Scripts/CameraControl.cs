using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    private Vector2 cameraSpeed;

    public float timeX;
    public float timeY;

    public GameObject player;

	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	void FixedUpdate () {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref cameraSpeed.x, timeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref cameraSpeed.y, timeY);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}