using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    float osa_x;
    float osa_y;
    public GameObject player;
    float mousesensitivi = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        osa_x -= Input.GetAxis("Mouse Y") * mousesensitivi;
        osa_y += Input.GetAxis("Mouse X") * mousesensitivi;

        osa_x = Mathf.Clamp(osa_x, 335, 420);

        transform.localEulerAngles = new Vector3(osa_x, 0,0);
        player.transform.localEulerAngles = new Vector3(0, osa_y, 0);
    }
}
