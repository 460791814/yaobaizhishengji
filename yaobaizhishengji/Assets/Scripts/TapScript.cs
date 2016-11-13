using UnityEngine;
using System.Collections;

public class TapScript : MonoBehaviour {
    public float speed=1;
    private bool isHit;
  
	// Use this for initialization
    void OnBecameInvisible()
    {
        GameObject.Find("body").GetComponent<PlayScript>().isStart = true;
       Destroy(gameObject);
    

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)&&GameObject.Find("Brand")==null)
        {
            isHit = true;
        }
        if (isHit) {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
	}
}
