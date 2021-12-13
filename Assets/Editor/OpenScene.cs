using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class OpenScene
{
    [MenuItem("Open Scene/Menu/Start Screen %#M")] //% is strg, & is alt, # is shift, 
    static void StartScreen()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Scenes/MainMenu.unity");
    }
    
    [MenuItem("Open Scene/GameLoop/Ingame Screen %#I")]
    static void InGameScreen()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Scenes/InGame.unity");
    }
}
