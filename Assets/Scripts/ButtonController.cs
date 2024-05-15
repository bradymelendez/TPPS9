using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void OnButtonPressed()
    {
        gameManager.ButtonPressed(gameObject);
    }
}