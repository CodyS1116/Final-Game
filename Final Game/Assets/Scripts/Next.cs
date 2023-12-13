using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
	public Color color1;
    public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.next == 1) {
			sr.color = color1;
			transform.localScale = new Vector2(0.5f, 0.5f);
		}
		else if (Global.next == 2) {
			sr.color = color2;
			transform.localScale = new Vector2(0.7f, 0.7f);
		}
		else if (Global.next == 3) {
			sr.color = color3;
			transform.localScale = new Vector2(0.95f, 0.95f);
		}
		else if (Global.next == 4) {
			sr.color = color4;
			transform.localScale = new Vector2(1.2f, 1.2f);
		}
		else if (Global.next == 5) {
			sr.color = color5;
			transform.localScale = new Vector2(1.5f, 1.5f);
		}
    }
}
