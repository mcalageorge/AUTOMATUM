using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera> ();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            GameObject[] q = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject i in q)
            {
                Destroy(i);
            }
        }
       
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin,pointToLook, Color.blue);
            pointToLook.y = transform.position.y;

            transform.LookAt(pointToLook);
        }
    }



}
