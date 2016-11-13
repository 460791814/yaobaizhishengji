using UnityEngine;
using System.Collections;

public class ManageScript : MonoBehaviour {

    public GameObject brand;
    public GameObject btnGroup;

    void Start()
    {
        print(PlayerPrefs.GetInt("score"));
        GameObject g = GameObject.Find("SelftScore");
        if(g!=null){
        g.GetComponent<SetScore>().SetSpriteScore(PlayerPrefs.GetInt("score"));
        }
    }

	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //创建一条射线
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo;
        //    if(Physics.Raycast(ray,out hitInfo))
        //    {
        //        //处理被碰撞到的物体
        //        print(hitInfo.collider.gameObject.name);
        //    }
        //}
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, vect, 100, 1 << LayerMask.NameToLayer("btn"));
            if (hit.collider!=null)
            {
              
                switch (hit.collider.name)
                {
                    case "btn_start":
                        Application.LoadLevel("pass");
                        break;
                    case "btn_rand":
                        break;
                    default:
                        break;
                }
            }
        }
	}
}
