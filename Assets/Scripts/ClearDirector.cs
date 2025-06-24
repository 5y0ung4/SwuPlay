using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    float score;
    public GameObject success;
    public GameObject fail;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //success = GameObject.Find("Success");
        //fail = GameObject.Find("Fail");
        success.SetActive(false);
        fail.SetActive(false);
        score = PlayerPrefs.GetFloat("EndScore", 0f);
        Debug.Log("Score: " + score);
         
        
        if(score >= 4.0f)
        {
            success.SetActive(true);
        }
        else
        {
            fail.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
