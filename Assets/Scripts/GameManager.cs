using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] buttons;
    public float activationTime = 2f;
    public float gameTime = 10f;
    public TextMeshProUGUI timerText;
    public string Va;

    private List<GameObject> remainingButtons = new List<GameObject>();
    private float timer = 0f;
    private bool gameOver = false;

    void Start()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
            remainingButtons.Add(button);
        }

        StartCoroutine(ActivateRandomButton());
    }

    void Update()
    {
        if (!gameOver)
        {
            timer += Time.deltaTime;
            timerText.text = "Tiempo restante: " + Mathf.Round(gameTime - timer).ToString();

            if (timer >= gameTime)
            {
                GameOver(false); 
            }
        }
    }

    IEnumerator ActivateRandomButton()
    {
        while (remainingButtons.Count > 0)
        {
            yield return new WaitForSeconds(activationTime);

            int randomIndex = Random.Range(0, remainingButtons.Count);
            GameObject buttonToActivate = remainingButtons[randomIndex];
            buttonToActivate.SetActive(true);
        }
    }

    public void ButtonPressed(GameObject pressedButton)
    {
        if (remainingButtons.Contains(pressedButton))
        {
            remainingButtons.Remove(pressedButton);
        }

        if (remainingButtons.Count == 0)
        {
            GameOver(true);
        }
    }

    void GameOver(bool success)
    {
        gameOver = true;
        if (success)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Va);
        }
        else
        {
            SceneManager.LoadScene("Derrota");
        }
    }
}