using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static private Text  _UI_TEXT;
    static private float   _SCORE = 0;

    private Text txtCom;

    void Awake() {
        _UI_TEXT = GetComponent<Text>();
    }

    static public float SCORE {
        get { return _SCORE; }
        private set {
            _SCORE = value;
            if (_UI_TEXT != null) {
                _UI_TEXT.text = "High Score: " + value.ToString("#,0");
            }
        }
    }

    static public void TRY_SET_HIGH_SCORE(float scoreToTry) {
        if (scoreToTry <= SCORE) return;
            SCORE = scoreToTry;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
