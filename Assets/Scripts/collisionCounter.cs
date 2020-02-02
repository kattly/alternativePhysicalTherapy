using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisionCounter : MonoBehaviour
{
    int winCondition = 10;
    int counter;
    public TextMesh scoreText;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        counter++;
        scoreText.GetComponent<TextMesh>().text = "Score: " + counter.ToString();

        if (counter >= winCondition)
        {
            scoreText.GetComponent<TextMesh>().text = "You win!!";

            SceneManager.LoadScene("MenuCabin");
            //backToMain();
        }
    }

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
