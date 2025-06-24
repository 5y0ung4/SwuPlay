using UnityEngine;

public class GradeController : MonoBehaviour
{
    GameObject player;
    GameObject gameDirector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player");
        this.gameDirector = GameObject.Find("GameDirector");
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject grade = GameObject.Find("grade");

        if (other.gameObject.name == "player")
        {
            if (CompareTag("A+"))
            {
                //GameManager.Instance.AddScore(goodItemScore);
                gameDirector.GetComponent<GameDirector>().GetGrade(4.5f);

            }
            else if (CompareTag("F"))
            {
                //GameObject director = GameObject.Find("GameDirector");
                //director.GetComponent<GameDirector>().DecreaseGauge();
                //GameManager.Instance.AddScore(badItemScore);
                gameDirector.GetComponent<GameDirector>().GetGrade(0f);
            }
            else if (CompareTag("C+"))
            {
                //GameManager.Instance.AddScore(badItemScore);
                gameDirector.GetComponent<GameDirector>().GetGrade(2.5f);
            }
            Destroy(gameObject);
        }

    }
}
