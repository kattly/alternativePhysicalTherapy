using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{

    public void loadI(string levelName)
    {
        load(levelName);
    }

    public static void load(string levelName)
    {
        Debug.Log(levelName);

        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
