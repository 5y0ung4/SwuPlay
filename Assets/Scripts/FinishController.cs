using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    GameObject gameDirector;
    float endScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameDirector = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("player"))
        {
            Debug.Log("Goal!");
            endScore = gameDirector.GetComponent<GameDirector>().GetTotalScore();
            PlayerPrefs.SetFloat("EndScore", endScore);
            PlayerPrefs.Save();

            SceneManager.LoadScene("ClearScene");
        }
    }
}
