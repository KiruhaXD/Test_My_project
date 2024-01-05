using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    
    [SerializeField] private static int health = 100; // �������� ���������
    [SerializeField] private static bool gameOver;
    
    public TMP_Text playerHealthText; 

    private void Start()
    {
        health = 100; // ��� ������ ���� � ��������� 100 ��
        gameOver = false;
    }

    private void Update()
    {
        playerHealthText.text = "" + health; // ��������� ����������� ������ �������� ���������

        if (gameOver) 
        {
            SceneManager.LoadScene("Level");
        }
    }

    public static void Damage(int damage) 
    {
        health -= damage;

        if (health <= 0) 
        {
            gameOver = true;
        }
    }


}
