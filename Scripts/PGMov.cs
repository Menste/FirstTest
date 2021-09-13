using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGMov: MonoBehaviour
{
    public GameObject pg;
  
    public float speed;
    public float horSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pg.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float h = Input.GetAxis("Horizontal") * horSpeed;

        pg.transform.Translate(h * Time.deltaTime, 0, 0);

    }
}
