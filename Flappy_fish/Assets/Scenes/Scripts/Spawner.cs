using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public float queueTime;
    private float time = 0;

    public GameObject obstacle;
    public float height;

    public TextMeshProUGUI scoreTextTMP; // Ссылка на TMP текст
    private int obstacleCount = 0; // Счётчик препятствий

    public Transform player; // Ссылка на игрока

    void Update()
    {
        if (time > queueTime)
        {
            // Создаём препятствие
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            // Передаём ссылку на игрока в скрипт препятствия
            go.GetComponent<obstacle>().player = player;

            time = 0;

            // Уничтожаем препятствие через 10 секунд
            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }

    // Метод для увеличения счётчика
    public void IncreaseScore()
    {
        obstacleCount++;
        UpdateScoreText();
    }

    // Метод для обновления текста на экране
    void UpdateScoreText()
    {
        scoreTextTMP.text = "Score: " + obstacleCount.ToString();
    }
}



