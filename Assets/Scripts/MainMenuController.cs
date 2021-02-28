using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private int currentColor = 0;
    public float transitionSpeed = 2.0f;
    public List<Material> skyMats;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeSky());
    }

    IEnumerator ChangeSky()
    {
        yield return new WaitForSeconds(transitionSpeed);
        RenderSettings.skybox = skyMats[IncColor(1)];
    }
    private int IncColor(int i)
    {
        currentColor += i;
        if ((int)currentColor > skyMats.Count)
            currentColor = 0;
        else if ((int)currentColor < 0)
            currentColor = skyMats.Count;

        return currentColor;
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
