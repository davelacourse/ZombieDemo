using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerLobby : MonoBehaviour
{


    public void OnDemarrerClick()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index+1);
    }

    public void onQuitterClick()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}





