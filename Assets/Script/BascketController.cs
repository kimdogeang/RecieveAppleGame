using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BascketController : MonoBehaviour
{
    GameObject director;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            this.director.GetComponent<GameDirector>().GetApple();
        }
        else
        {
            this.director.GetComponent<GameDirector>().GetBomb();

        }
        Destroy(other.gameObject);
    
}
    void Start()
    {
        this.director = GameObject.Find("GameDirector");

    }

    


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
   
} 
