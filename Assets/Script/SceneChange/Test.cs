using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Test: MonoBehaviour
{
    [SerializeField] private GameObject _loadingUI;
    [SerializeField] private Slider _slider;
    public void LoadNextScene()
    {
        _loadingUI.SetActive(true);
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("GameScene");
        while (!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            _slider.value = progressVal/10.0f;
            yield return null;
        }
    }
}
