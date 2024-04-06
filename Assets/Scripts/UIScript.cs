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

    [SerializeField] private GameObject _menu, _camera;
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
        _menu.SetActive(false);
        
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        GameManager.Instance.changeGameState(GameManager.GameState.Playing);

    }
}
