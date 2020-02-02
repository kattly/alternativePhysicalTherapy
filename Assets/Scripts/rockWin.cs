using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class rockWin : MonoBehaviour
{
    public TextMesh scoreText;

    // Start is called before the first frame update
    public void loading()
    {
        scoreText.GetComponent<TextMesh>().text = "You win!!";
        SceneManager.LoadScene("MenuCabin");
        //backToMain();
    }

    public IEnumerator backToMain()
    {
        Debug.Log("Loading");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MenuCabin");
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
