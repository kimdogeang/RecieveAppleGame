using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BascketController : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);

            }


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("ㅈ바았다!");?? 정전남
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("Tag = Apple");
        }
        
    }
} 
