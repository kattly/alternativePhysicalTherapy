using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class endRockGame : MonoBehaviour
{
    float timer;
    bool done;
    public TextMesh scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            timer += Time.deltaTime;
            scoreText.GetComponent<TextMesh>().text = "Time: " + timer.ToString("n2");
        }
        
    }

//    void OnCollisionEnter(Collision collision)
//    {
//        counter++;
//
//
//        if (counter >= winCondition)
//        {
//            scoreText.GetComponent<TextMesh>().text = "You win!!";
//
//            SceneManager.LoadScene("MenuCabin");
//            //backToMain();
//        }
//    }

    IEnumerator backToMain()
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
