using UnityEngine;
using System.Collections;

public class SetScore : MonoBehaviour {

    private Sprite[] sprites;
    public string Name = "PreSprites";
    void Awake()
    {
        sprites = Resources.LoadAll<Sprite>(Name);
    }

	
	// Update is called once per frame
	public  void SetSpriteScore(int num) {
        GetComponent<SpriteRenderer>().sprite = sprites[num + 1];
	}
}
