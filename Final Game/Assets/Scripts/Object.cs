using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
	public GameObject Circle2;
	public GameObject Circle3;
	public GameObject Circle4;
	public GameObject Circle5;
	public GameObject Circle6;
	public GameObject Circle7;
	public GameObject Circle8;
	public GameObject Circle9;
	public GameObject Circle10;
	public GameObject Circle11;
	public static float topY = 4.35f;
	public int num = 0;
	public GameObject collidedWith;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= topY) {
            Global.gameEnd = true;
        }
		if (Global.gameEnd) {
			Destroy(gameObject);
			ScoreCounter.score = 0f;
		}
		HighScore.TRY_SET_HIGH_SCORE(ScoreCounter.score);
    }
	
	
	
	void OnCollisionEnter2D(Collision2D coll)
    {
        collidedWith = coll.gameObject;
		if (collidedWith.layer == gameObject.layer) {
			num = Global.currentShapes;
			int ID = gameObject.GetInstanceID();
			int other = collidedWith.GetInstanceID();
			if (ID > other) {
	
				if (collidedWith.CompareTag("1") && gameObject.CompareTag("1")) {
					GameObject circle2 = Instantiate<GameObject>(Circle2);
					circle2.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 1f;
					
				}
				else if (collidedWith.CompareTag("2") && gameObject.CompareTag("2")) {
					GameObject circle3 = Instantiate<GameObject>(Circle3);
					circle3.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 3f;
					
				}
				else if (collidedWith.CompareTag("3") && gameObject.CompareTag("3")) {
					GameObject circle4 = Instantiate<GameObject>(Circle4);
					circle4.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 6f;
				}
				else if (collidedWith.CompareTag("4") && gameObject.CompareTag("4")) {
					GameObject circle5 = Instantiate<GameObject>(Circle5);
					circle5.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 10f;
				}
				else if (collidedWith.CompareTag("5") && gameObject.CompareTag("5")) {
					GameObject circle6 = Instantiate<GameObject>(Circle6);
					circle6.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 15f;
				}
				else if (collidedWith.CompareTag("6") && gameObject.CompareTag("6")) {
					GameObject circle7 = Instantiate<GameObject>(Circle7);
					circle7.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 21f;
				}
				else if (collidedWith.CompareTag("7") && gameObject.CompareTag("7")) {
					GameObject circle8 = Instantiate<GameObject>(Circle8);
					circle8.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 28f;
				}
				else if (collidedWith.CompareTag("8") && gameObject.CompareTag("8")) {
					GameObject circle9 = Instantiate<GameObject>(Circle9);
					circle9.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 36f;
				}
				else if (collidedWith.CompareTag("9") && gameObject.CompareTag("9")) {
					GameObject circle10 = Instantiate<GameObject>(Circle10);
					circle10.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 45f;
				}
				else if (collidedWith.CompareTag("10") && gameObject.CompareTag("10")) {
					GameObject circle11 = Instantiate<GameObject>(Circle11);
					circle11.transform.position = transform.position;
					Dropper.PlaySound();
					Destroy(collidedWith);
					Destroy(gameObject);
					ScoreCounter.score += 55f;
				}
				else if (collidedWith.CompareTag("11") && gameObject.CompareTag("11")) {
					Global.currentShapes -= 1;
					Dropper.PlaySound();
					ScoreCounter.score += 66f;
					Destroy(collidedWith);
					Destroy(gameObject);
				}
			}
		}
    }
	
}
