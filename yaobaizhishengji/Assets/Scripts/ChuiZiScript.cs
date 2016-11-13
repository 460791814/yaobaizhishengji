using UnityEngine;
using System.Collections;

public class ChuiZiScript : MonoBehaviour {

    private bool IsTure=true;
    Quaternion target;
	// Use this for initialization
	void Start () {
        iTween.RotateTo(gameObject, iTween.Hash("z", 30, "time", 1, "loopType", iTween.LoopType.pingPong, "easeType", iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {

      
        //if (IsTure)
        //{
        //    target = Quaternion.Euler(transform.position.x, transform.position.y, -30);

        //}else
    
        //{
        //    target = Quaternion.Euler(transform.position.x, transform.position.y, 30);

        //}
	}

    void LateUpdate()
    {
       //// target = Quaternion.Euler(transform.position.x, transform.position.y, 30);
       // transform.rotation = Quaternion.Lerp(transform.rotation, target, 0.1f);

       // print(transform.rotation + "---" + target);
       // if (transform.rotation == target && transform.rotation ==target)
       // {
       //     IsTure = !IsTure;
       // }
    }
}
