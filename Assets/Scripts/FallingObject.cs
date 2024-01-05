using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public int damageAmount = 10; // ���������� �����, ���������� ��������

    private void OnCollisionEnter(Collision other)
    {
        HealthPlayer.Damage(damageAmount);
    }
}
