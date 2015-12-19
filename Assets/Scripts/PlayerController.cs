using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public float RotationSpeed;
    public float Smooth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float vertTranslation = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        float horiTranslation = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        //float vertRotation = Input.GetAxis("Mouse Y") * Speed;
        //float horiRotation = Input.GetAxis("Mouse X") * Speed;

        //Mathf.Clamp(vertRotation, -90, 90);
        //Mathf.Clamp(horiRotation, -90, 90);

        transform.Translate(horiTranslation, 0, vertTranslation);
        //float newRotationX = transform.rotation.x + horiTranslation;
        //float newRotationZ = transform.rotation.z + vertTranslation;

        //transform.Rotate(-vertRotation, horiRotation, 0);
        
        float tiltAroundX = transform.rotation.x + Input.GetAxis("Mouse Y") * RotationSpeed;
        float tiltAroundY = transform.rotation.y + Input.GetAxis("Mouse X") * RotationSpeed;
        //Mathf.Clamp(tiltAroundX, -90, 90);
        //Mathf.Clamp(tiltAroundZ, -90, 90);
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);
        transform.rotation = target;
        //transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * Smooth);
    }
}
