using UnityEngine;

public class ZoneMarker : MonoBehaviour
{
    // префаб зоны 
    public GameObject zonePrefab;

    // переменная для хранения ссылки на текующую зону
    private GameObject currentZone;
    private float objectsLifeTime = 10f;

    private void Start()
    {
        // вызываем ее
        ZoneFallForObject();
    }

    // создаем зону падения для объекта
    void ZoneFallForObject() 
    {
        // проверяем, что префаб зоны существует
        if (zonePrefab != null) 
        {
            // создаем новую зону из префаба
            currentZone = Instantiate(zonePrefab);

            if (currentZone != null)
            {
                //Уничтожаем зону
                Destroy(currentZone, objectsLifeTime);
            }

            // устанавливаем позицию зоны на 0.01 по y
            currentZone.transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z);

            // Получаем размеры объекта (ширину и высоту) для установки размеров зоны
            Renderer rendererZone = new Renderer();
            float objectWidth = rendererZone.bounds.size.x;
            float objectHeight = rendererZone.bounds.size.z;

            // устанавливаем размер зоны с соотвутсвующими размерами объекта
            currentZone.transform.localScale = new Vector3(objectWidth, 1f, objectHeight);

            // активируем зону
            currentZone.SetActive(true);

            
        }
    }
}
