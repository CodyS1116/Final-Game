using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
	public GameObject Circle1;
	public GameObject Circle2;
	public GameObject Circle3;
	public GameObject Circle4;
	public GameObject Circle5;
	public float delay = .5f;
	public float countdown = 0f;
	public float current = 1f;
	public float next = 0f;
	public Color color1;
    public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	public Color color6;
	public AudioSource drop;
	public static AudioSource combine;
	SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        current = 1;
		next = Random.Range(1, 6);
		Global.next = next;
		sr = GetComponent<SpriteRenderer>();
		var sounds = GetComponents<AudioSource>();
		drop = sounds[0];
		combine = sounds[1];
    }

    // Update is called once per frame
    void Update()
    {
		Vector2 pos = transform.position;
		Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector2(mouse.x, transform.position.y);
		if (countdown < 0f) {
			Global.next = next;
			if (current == 1) {
				sr.color = color1;
				transform.localScale = new Vector2(0.5f, 0.5f);
			}
			else if (current == 2) {
				sr.color = color2;
				transform.localScale = new Vector2(0.7f, 0.7f);
			}
			else if (current == 3) {
				sr.color = color3;
				transform.localScale = new Vector2(0.95f, 0.95f);
			}
			else if (current == 4) {
				sr.color = color4;
				transform.localScale = new Vector2(1.2f, 1.2f);
			}
			else if (current == 5) {
				sr.color = color5;
				transform.localScale = new Vector2(1.5f, 1.5f);
			}
			if (pos.x > -3 && pos.x < 3) {
				if (Input.GetMouseButtonDown(0)) {
					countdown = delay;
					Invoke("DropShape", 0);
				}
			}
		}
		countdown -= Time.deltaTime;
		if (Global.gameEnd) {
			StartCoroutine(waiter());
		}
    }
	
	void DropShape() {
		sr.color = color6;
		drop.Play(0);
		if (current == 1) {	
			GameObject circle1 = Instantiate<GameObject>(Circle1);
			circle1.transform.position = transform.position;
		}
		else if (current == 2) {	
			GameObject circle2 = Instantiate<GameObject>(Circle2);
			circle2.transform.position = transform.position;
		}
		else if (current == 3) {	
			GameObject circle3 = Instantiate<GameObject>(Circle3);
			circle3.transform.position = transform.position;
		} 
		else if (current == 4) {	
			GameObject circle4 = Instantiate<GameObject>(Circle4);
			circle4.transform.position = transform.position;
		} 
		else if (current == 5) {	
			GameObject circle5 = Instantiate<GameObject>(Circle5);
			circle5.transform.position = transform.position;
		}
		Global.currentShapes += 1;
		current = next;
		next = Random.Range(1, 6);
    }
	
	public static void PlaySound() {
		combine.Play(0);
	}
	
	IEnumerator waiter() {
		yield return new WaitForSeconds(.8f);
		Global.gameEnd = false;
	}
	
}
