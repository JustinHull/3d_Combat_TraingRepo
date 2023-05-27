using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    #region Text Variables
    //private int pickUpCount;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    #endregion

    #region Game State Variables
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    #endregion

    private void Start()
    {
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            loseTextObject.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetCountText(int count)
    {
        countText.text = count.ToString();
        if (count == 12)
        {
            winTextObject.SetActive(true);
        }
    }
}

