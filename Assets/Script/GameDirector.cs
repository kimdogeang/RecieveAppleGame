using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    public Text timeText;
    float time = 30.0f;
    int point = 0;
    GameObject generator;

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("ItemGenerator");
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this time;
        
        //if (Input.GetMouseButtonDown(0))
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
¾ÈÇØ