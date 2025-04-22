using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Invoke("GoToMainMenu", 2f);
    }

    void GoToMainMenu()
    {
        GameManager.Instance.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
