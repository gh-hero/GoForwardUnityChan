using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSE : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //他のオブジェクトと接触した場合の処理
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Block" || other.gameObject.tag == "Road")
        {

            //効果音を鳴らす
            GetComponent<AudioSource>().Play();

        }

    }

}
