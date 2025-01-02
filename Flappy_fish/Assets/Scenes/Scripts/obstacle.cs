using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;
    public Transform player; // Ссылка на объект игрока
    private bool counted = false; // Флаг, чтобы препятствие засчитывалось только один раз

    // Update is called once per frame
    void Update()
    {
        // Двигаем препятствие влево
        transform.position += ((Vector3.left * speed) * Time.deltaTime);

        // Проверяем, прошло ли препятствие игрока
        if (!counted && transform.position.x < player.position.x)
        {
            counted = true; // Устанавливаем флаг
            FindObjectOfType<Spawner>().IncreaseScore(); // Увеличиваем счётчик
        }
    }
}
