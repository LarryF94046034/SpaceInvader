using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    //public GameObject Bullet;   //改成手機觸控移動、

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // if(Input.GetKey(KeyCode.RightArrow))
        // { 
        //     gameObject.transform.position += new Vector3(0.1f, 0, 0);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        // }
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Vector3 pos = gameObject.transform.position + new Vector3(0,0.6f,0);

        //     Instantiate(Bullet,pos,gameObject.transform.rotation);

        // }

        if (Input.GetTouch(0).phase == TouchPhase.Moved) //如果觸控的狀態是拖曳
        {
            float x = Input.touches[0].deltaPosition.x * Time.deltaTime * 0.5f;
            float y = Input.touches[0].deltaPosition.y * Time.deltaTime * 0.5f;
            transform.Translate(new Vector3(x, y, 0));
        }


    }
}
