using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    private bool gameOverTriggered = false;
    public GameObject tutorial;
    [SerializeField] AudioManager audioManager;

[ContextMenu("Increase Score")]
    public void addScore() {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
   void Update() {
        if (gameOverTriggered && (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
         gameOverTriggered = true;
    }

   public void tutorialSet() {
    tutorial.SetActive(!tutorial.activeSelf);
}
}
