using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour
{
    int totalScenes = 0;
    int currentSceneIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalScenes = SceneManager.sceneCountInBuildSettings;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (currentSceneIndex < totalScenes - 1)
            {
                currentSceneIndex++;
            } else
            {
                currentSceneIndex = 0;
            }
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}
