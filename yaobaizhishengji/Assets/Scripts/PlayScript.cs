using UnityEngine;
using System.Collections;

public class PlayScript : MonoBehaviour
{
    private Transform MyTranform;
    public Vector3 speed = new Vector3(1, 1, 0);
    public Vector3 direction = new Vector3(0, 1, 0);
    public bool isStart;
    private bool xy;
  
    public int Level=0;//关卡
    private Vector3 CamreaPosition;
    private bool isfail = false;//游戏失败
    // Use this for initialization
    void Start()
    {
        MyTranform = transform;
        CamreaPosition = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
        Vector3 vector = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
        vector = vector * Time.deltaTime;
      
        if (isStart)
        {
          
            transform.transform.Translate(vector);
            Camera.main.transform.Translate(vector);
            GameObject.Find("SelftScore").transform.Translate(vector);
            if (xy)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
             
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
             
            }
            transform.Translate(Vector3.right * Time.deltaTime * 1);   
        }
        if (Input.GetMouseButtonDown(0))
        {
            xy = !xy;
        }
      
    }

    /// <summary>
    /// 物理碰撞 必须双方都带有rigibody组件
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter2D(Collision2D col)
    {
      //  print(col.gameObject.name);
    }
    /// <summary>
    /// 触发 必须有一方带有rigibody组件 且碰撞双方必须有一个勾选isTrigger
    /// 物体父级带有rigibody   子物体也会带有相应的属性，但是在界面上不会显示出来
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPrefs.SetInt("score", Level);
        if (other.gameObject.name == "Obstacle")
        {
            if (isfail == false)
            {
                Level += 1;
              //  other.SendMessage("SetSpriteScore", Level);
               GameObject.Find("SelftScore").GetComponent<SetScore>().SetSpriteScore(Level);
            }
           
        }
        else {

            isfail = true;
           
          transform.rigidbody2D.isKinematic = false;
          speed = Vector3.zero;
          Application.LoadLevel("fail");
        

        }
    }
    void LateUpdate() {

        ClampPlayer();
    }
    void OnGUI()
    {
     
        GUI.Label(new Rect(0,0,100,100),Level.ToString());
    }
    void ClampPlayer()
    {
        float dist = transform.position.z - Camera.main.transform.position.z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
        transform.position = new Vector3(Mathf.Clamp(MyTranform.position.x, leftBorder, rightBorder)
            , Mathf.Clamp(MyTranform.position.y, topBorder, bottomBorder)
            , MyTranform.position.z
            );
    }

}
