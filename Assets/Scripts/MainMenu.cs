using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("cargando escena" + sceneName);
        }
        else
        {
            Debug.LogWarning("El nombre de la escena no está asignado.");
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha salido");
    }


}
