using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private int playerID1 = 1;
    private int playerID2 = 2;

    private void Update()
    {
        if(Input.GetButtonDown("P" + playerID1 + "_Interact") || Input.GetButtonDown("P" + playerID2 + "_Interact"))
        {
            Debug.Log("Next scene loaded");
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Next scene loaded");
            SceneManager.LoadScene(1);
        }
    }
}
