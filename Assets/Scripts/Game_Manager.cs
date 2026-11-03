using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    private void Update() //reset level
    {
        if (Input.GetKey(KeyCode.R)) //add confirmation noti **
        {
            SceneManager.LoadScene("Game");
        }
    }
}
