using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HedgehogTeam.EasyTouch;

public class FirstTextScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // テキストが出て消えた数
    public int first_textCount;

    public void On_TouchStart(Gesture gesture)
    {
        gameObject.SetActive(true);

        StartCoroutine(Checking(() =>
        {
            // 音が終わったらテキストを消す
            gameObject.SetActive(false);
            // テキストが出て消えた数カウント
            first_textCount++;
        }));
    }

    private AudioSource audio;

    public delegate void functionType();
    private IEnumerator Checking(functionType callback)
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (!audio.isPlaying)
            {
                callback();
                break;
            }
        }
    }
}
