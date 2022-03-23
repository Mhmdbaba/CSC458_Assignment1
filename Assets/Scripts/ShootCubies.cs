using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCubies : MonoBehaviour
{

    [SerializeField]
    GameObject BulletToInstntiate;

    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    GameObject instanceBullet;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
             instanceBullet = Instantiate(BulletToInstntiate,transform.position, transform.rotation) as GameObject;

            instanceBullet.GetComponent<Rigidbody>().velocity = instanceBullet.transform.forward*100;

            instanceBullet.name = "bullet" + counter;
            counter++;

        }
    }
}
