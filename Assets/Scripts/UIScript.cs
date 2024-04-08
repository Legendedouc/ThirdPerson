using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class UIScript : MonoBehaviour
{
    private UIDocument _mainMenuUI, _ingameUIDocument;
    private Button _button;
    private Label _highscore;

    [SerializeField] private GameObject _menu, _camera, _ingameUI;
    // Start is called before the first frame update
    void Awake()
    {
        _mainMenuUI = _menu.GetComponent<UIDocument>();
        _ingameUIDocument = _ingameUI.GetComponent<UIDocument>();
        _button = _mainMenuUI.rootVisualElement.Q("Start") as Button;
        _button.RegisterCallback<ClickEvent>(StartGameClick);
    }

    private void Update()
    {
        _highscore = new Label(GameManager.Instance.Highscore + "");
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
