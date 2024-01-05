using UnityEngine;

public class SpawnManagerForFallObjects : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    private float spawnInterval = 1f;
    private float objectsLifeTime = 10f;

    private void Start()
    {
        // Запускаем спавн объектов с указанным интервалом времени
        InvokeRepeating("SpawnObjects", 1f, spawnInterval);
    }

    private void SpawnObjects() 
    {
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        GameObject spawnedObjects = Instantiate(objectsToSpawn[randomIndex], GetRandomPosition(), Quaternion.identity);

        // Удаляем объект через objectLifetime секунд
        Destroy(spawnedObjects, objectsLifeTime);
    }

    private Vector3 GetRandomPosition() 
    {
        // Генерируем случайные координаты X и Z в заданном диапазоне
        float randomX = Random.Range(-10f, 10f);
        float randomZ = Random.Range(-10f, 10f);

        // Возвращаем случайную позицию с фиксированной Y-координатой
        return new Vector3(randomX, 15, randomZ);
    }
}
