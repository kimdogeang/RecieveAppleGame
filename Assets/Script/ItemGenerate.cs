using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    int ratio = 2;

    float speed = -0.03f;

    public void SetParameter(float span, float speed ,int ratio)
    {
        this.span = span;
        delta = delta;
        ratio = ratio;
    }

    public void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if(dice <= this.ratio)
            {
                item = Instantiate(bombPrefab);
            }


            else
            {
                
                item = Instantiate(applePrefab);

                float x = Random.Range(-1, 2);
                float z = Random.Range(-1, 2);

                item.transform.position = new Vector3(x, 4, z);

                item.GetComponent<ItemController>.dropSpeed = this.speed;
            }
        }

    }
}
