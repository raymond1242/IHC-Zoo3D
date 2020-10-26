using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescena : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void CameraScene()
    {
        SceneManager.LoadScene(1);
    }
    public void VideoScene()
    {
        SceneManager.LoadScene(4);
    }
    public void QuizScene()
    {
        SceneManager.LoadScene(5);
    }
    public void HelpScene()
    {
        SceneManager.LoadScene(2);
    }
    public void CardScene()
    {
        SceneManager.LoadScene(3);
    }
    public void StoreScene()
    {
        SceneManager.LoadScene(6);
    }
    public void QUIT()
    {
        Application.Quit();
    }
}
