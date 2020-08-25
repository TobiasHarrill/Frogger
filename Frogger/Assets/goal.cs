using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    void OnTriggerEnter2D ()
    {
        Debug.Log("YOU WON!");
        Score.CurrentScore += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
