using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class UIScript : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;
    // Start is called before the first frame update
    void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q("Start") as Button;
        _button.RegisterCallback<ClickEvent>(StartGameClick);
    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(StartGameClick);
    }

    private void StartGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene(1);
    }
}
