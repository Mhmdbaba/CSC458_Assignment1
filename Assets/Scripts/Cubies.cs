using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubies : MonoBehaviour
{



    [SerializeField]
    GameObject cubeToInstantiate;

    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if(Input.GetKeyDown(KeyCode.Mouse0)){
                    GameObject currentCube = Instantiate(cubeToInstantiate, transform.position, transform.rotation) as GameObject;
                    currentCube.GetComponent<Rigidbody>().velocity = currentCube.transform.forward*100;
                    currentCube.name = "Cube " + counter++;
                    Debug.Log("shot");
                }
    }
}
