using UnityEditor;
using UnityEngine;
using Kyusyukeigo.Helper;

[InitializeOnLoad]
public class SceneGUI
{
  static SceneGUI()
  {
    // Sceneビューにウィンドウを出す
    SceneView.onSceneGUIDelegate += (sceneView) =>
    {
      Handles.BeginGUI();
      GUILayout.Window(1, new Rect(20, 20, 120, 47), OnGUI, "Window");
      Handles.EndGUI();
    };
  }

  static void OnGUI(int id)
  {
    if (GUILayout.Button("Add GameViewSizes"))
    {
      // iOS端末の解像度を一括で登録
      AddGameViewSizes();
    }
  }

  static void AddGameViewSizes()
  {
    AddGameViewSize("iPhone", 320, 480);
    AddGameViewSize("iPhone", 480, 320);
    AddGameViewSize("iPhone 4", 640, 960);
    AddGameViewSize("iPhone 4", 960, 640);
    AddGameViewSize("iPhone 6", 750, 1334);
    AddGameViewSize("iPhone 6", 1334, 750);
    AddGameViewSize("iPhone 6s", 640, 1136);
    AddGameViewSize("iPhone 6s", 1136, 640);
    AddGameViewSize("iPhone 6s Plus", 1242, 2208);
    AddGameViewSize("iPhone 6s Plus", 2208, 1242);
    AddGameViewSize("iPhone 6 Plus", 1125, 2001);
    AddGameViewSize("iPhone 10", 1125, 2436);
    AddGameViewSize("iPhone 10", 2436, 1125);
    AddGameViewSize("iPad Mini", 768, 1024);
    AddGameViewSize("iPad Mini", 1024, 768);
    AddGameViewSize("iPad Mini 3", 1536, 2048);
    AddGameViewSize("iPad Mini 3", 2048, 1536);
    AddGameViewSize("iPad", 768, 1024);
    AddGameViewSize("iPad", 1024, 768);
    AddGameViewSize("iPad 4", 1536, 2048);
    AddGameViewSize("iPad 4", 2048, 1536);
    AddGameViewSize("iPad Air", 1668, 2224);
    AddGameViewSize("iPad Air", 2224, 1668);
    AddGameViewSize("iPad Pro 12.9", 2048, 2732);
    AddGameViewSize("iPad Pro 12.9", 2732, 2048);
  }

  static void AddGameViewSize(string baseText, int width, int height)
  {
    Debug.Log("AddGameViewSize : " + baseText + ", width = " + width + ", height = " + height);

    Kyusyukeigo.Helper.GameViewSizeHelper.AddCustomSize(
      GameViewSizeGroupType.Standalone,
      new GameViewSizeHelper.GameViewSize
      {
        baseText = baseText,
        type = GameViewSizeHelper.GameViewSizeType.FixedResolution,
        width = width,
        height = height
      }
      );
  }
}