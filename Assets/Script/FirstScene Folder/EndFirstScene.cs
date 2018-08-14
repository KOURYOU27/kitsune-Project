using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HedgehogTeam.EasyTouch;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class EndFirstScene : MonoBehaviour {

    //パネル参照
    public PanelFadeScript panelFadeScript;
    GameObject Panel;
    public float fadeSpeed = 0.02f;

    float time;//時間を記録する小数も入る変数.
    // Use this for initialization
    void Start () {
        time = 0;

        Panel = GameObject.Find("Panel"); //パネルをオブジェクトの名前から取得して変数に格納する
        panelFadeScript = Panel.GetComponent<PanelFadeScript>(); //パネルの中にあるパネルChanScriptを取得して変数に格納する
    }

    // FirstTextScript参照
    public FirstTextScript textScript;


    // AudioSource参照
    public AudioSource AudioSource;
    public float FadeTime = 3.0f;
    private float volume;


    // Update is called once per frame
    void Update () {

        time += Time.deltaTime;//毎フレームの時間を加算.

        int tCount;
        // FirstTextScriptの変数ゲット
        tCount = textScript.first_textCount;

        this.volume = this.AudioSource.volume;


        if ((time >= 30) && (tCount == 1))
        {
            this.AudioSource.DOFade(0.0f, FadeTime).SetEase(Ease.Linear);
            panelFadeScript.StartFadeOut();

            if (panelFadeScript.alfa >= 1)
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
        if ((time <= 30) && (tCount == 3))
        {
            this.AudioSource.DOFade(0.0f, FadeTime).SetEase(Ease.Linear);
            panelFadeScript.StartFadeOut();

            if (panelFadeScript.alfa >= 1)
            {
                SceneManager.LoadScene("TitleScene");
            }

        }
        if (tCount >= 1)
        {
            if (time >= 27)
            {
                GameObject sphere100 = GameObject.Find("Sphere100");
                Destroy(sphere100.GetComponent<QuickTap>());

            }
            if (time >= 30)
            {
                this.AudioSource.DOFade(0.0f, FadeTime).SetEase(Ease.Linear);
                panelFadeScript.StartFadeOut();

                if (panelFadeScript.alfa >= 1)
                {
                    SceneManager.LoadScene("TitleScene");
                }

            }
        }



    }

}
