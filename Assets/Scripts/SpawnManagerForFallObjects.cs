using UnityEngine;

public class SpawnManagerForFallObjects : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    private float spawnInterval = 1f;
    private float objectsLifeTime = 10f;

    private void Start()
    {
        // ��������� ����� �������� � ��������� ���������� �������
        InvokeRepeating("SpawnObjects", 1f, spawnInterval);
    }

    private void SpawnObjects() 
    {
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        GameObject spawnedObjects = Instantiate(objectsToSpawn[randomIndex], GetRandomPosition(), Quaternion.identity);

        // ������� ������ ����� objectLifetime ������
        Destroy(spawnedObjects, objectsLifeTime);
    }

    private Vector3 GetRandomPosition() 
    {
        // ���������� ��������� ���������� X � Z � �������� ���������
        float randomX = Random.Range(-10f, 10f);
        float randomZ = Random.Range(-10f, 10f);

        // ���������� ��������� ������� � ������������� Y-�����������
        return new Vector3(randomX, 15, randomZ);
    }
}
