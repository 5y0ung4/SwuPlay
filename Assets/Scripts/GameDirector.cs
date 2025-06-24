using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject gauge;
    Image gaugeImage;
    GameObject grage;
    
    float numCount = 1f;
    public float totalScore = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Application.targetFrameRate = 60;
        
        this.grage = GameObject.Find("grade");
        this.gauge = GameObject.Find("gauge");
        gaugeImage = this.gauge.GetComponent<Image>();
       

    }

    // Update is called once per frame
    void Update()
    {
        gaugeImage.fillAmount = Mathf.Max(0f, gaugeImage.fillAmount - 0.065f * Time.deltaTime);
        if(gaugeImage.fillAmount <= 0f)
        {
            Debug.Log("GameOver!");
            SceneManager.LoadScene("GameOver");
        }
    }
    public void GetGrade(float num)
    {
        numCount += 1f;
        totalScore += num;
        float average = totalScore / numCount;
        this.grage.GetComponent<TextMeshProUGUI>().text = "GPA: " + average.ToString("F2");
        
    }
    public float GetTotalScore()
    {
        return totalScore / numCount;
    }
}
