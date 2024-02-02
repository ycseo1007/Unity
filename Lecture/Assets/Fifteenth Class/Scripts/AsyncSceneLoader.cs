using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsyncSceneLoader : MonoBehaviour
{
    public GameObject sceneImage;
    public Slider loadSlider;

    public void SyncSceneLoad()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void AsyncSceneLoad()
    {
        StartCoroutine(LoadScene());
    }

    public IEnumerator LoadScene()
    {
        yield return null;

        sceneImage.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Game Scene");

        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            yield return null;

            if (asyncOperation.progress < 0.9f)
            {
                loadSlider.value = Mathf.Lerp(loadSlider.value, asyncOperation.progress, Time.deltaTime);
            }
            else /* Fake Loading */
            {
                loadSlider.value = Mathf.Lerp(loadSlider.value, 1f, Time.deltaTime);

                if (loadSlider.value >= 1.0f)
                {
                    asyncOperation.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
