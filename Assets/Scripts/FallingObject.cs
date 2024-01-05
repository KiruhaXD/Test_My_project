using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public int damageAmount = 10; // Количество урона, наносимого объектом

    private void OnCollisionEnter(Collision other)
    {
        HealthPlayer.Damage(damageAmount);
    }
}
