using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotazionePistola : MonoBehaviour
{
    public GameObject gun;
    public float gunRotation;
    float gunAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunAngle += Input.GetAxis("Mouse X") * gunRotation * Time.deltaTime;
        gunAngle = Mathf.Clamp(gunAngle, -90, 90);
        gun.transform.localRotation = Quaternion.AngleAxis(gunAngle, Vector3.down);
    }
}
