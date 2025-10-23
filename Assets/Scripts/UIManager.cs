using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public Image timerImage;
    public TMP_Text bottomText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.ResetTimer();
        bottomText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer ()
    {
        GameManager.instance.timeRemaining -= Time.deltaTime;
        timerImage.fillAmount = GameManager.instance.timeRemaining / GameManager.instance.maxTime;
        float displayTimeRemaining = (Mathf.Round(GameManager.instance.timeRemaining * 100)) /100;
        bottomText.text = "Time Remaining: " + displayTimeRemaining;
    }
}
