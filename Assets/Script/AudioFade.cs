using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class AudioFade : MonoBehaviour {

    public AudioSource AudioSource;
    public float FadeTime = 3.0f;

    private float volume;

    // Use this for initialization
    void Awake () {

        this.volume = this.AudioSource.volume;
        //フェードイン
        this.AudioSource.DOFade(0.8f, FadeTime).SetEase(Ease.Linear);

    }
	

}
