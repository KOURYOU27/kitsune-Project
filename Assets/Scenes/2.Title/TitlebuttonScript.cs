using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitlebuttonScript : MonoBehaviour {

    // 次のシーンへ
    public　void OnPointerUp() {

        SceneManager.LoadScene("Souchi1Scene");

    }
	
}
