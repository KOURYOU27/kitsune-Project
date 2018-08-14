using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language_test : MonoBehaviour {


    bool a;
    bool b;

    void Start()
    {

        a = LanguageChoice.getA();
        b = LanguageChoice.getB();
    }


    private Text targetText; // <---- 追加2
	
	// Update is called once per frame
	void Update () {

        this.targetText = this.GetComponent<Text>();

        if (a == true)
        {


            this.targetText.text = "日本語"; // <---- 追加4


        }

        if (b == true)
        {


            this.targetText.text = "英語"; // <---- 追加4


        }

    }
}
