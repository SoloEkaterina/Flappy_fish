using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;        // Кнопка для начала игры
    public GameObject restartButton;     // Кнопка для рестарта
    public Player player;                // Ссылка на игрока

    // Start is called before the first frame update
    void Start()
    {
        restartButton.SetActive(false);  // Прячем кнопку рестарта
        Time.timeScale = 0;              // Игра на паузе до начала
    }
    private void Update()
    {
        if (player.isDead)
        {
            ShowRestartButton();         // Показываем кнопку рестарта при смерти игрока
        }
    }
    // Запуск игры
    public void StartGame()
    {
        startButton.SetActive(false);    // Убираем кнопку старта
        Time.timeScale = 1;              // Запускаем игровой процесс
    }

    // Обработка окончания игры
    public void GameOver()
    {
        Time.timeScale = 0;              // Останавливаем время
    }

    // Показ кнопки рестарта
    private void ShowRestartButton()
    {
        restartButton.SetActive(true);   // Делаем кнопку рестарта видимой
    }

    // Перезапуск сцены (привязывается к кнопке рестарта)
    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0); // Перезагружаем сцену
    }
}

