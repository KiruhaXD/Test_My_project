using UnityEngine;

public class ZoneMarker : MonoBehaviour
{
    // ������ ���� 
    public GameObject zonePrefab;

    // ���������� ��� �������� ������ �� �������� ����
    private GameObject currentZone;
    private float objectsLifeTime = 10f;

    private void Start()
    {
        // �������� ��
        ZoneFallForObject();
    }

    // ������� ���� ������� ��� �������
    void ZoneFallForObject() 
    {
        // ���������, ��� ������ ���� ����������
        if (zonePrefab != null) 
        {
            // ������� ����� ���� �� �������
            currentZone = Instantiate(zonePrefab);

            if (currentZone != null)
            {
                //���������� ����
                Destroy(currentZone, objectsLifeTime);
            }

            // ������������� ������� ���� �� 0.01 �� y
            currentZone.transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z);

            // �������� ������� ������� (������ � ������) ��� ��������� �������� ����
            Renderer rendererZone = new Renderer();
            float objectWidth = rendererZone.bounds.size.x;
            float objectHeight = rendererZone.bounds.size.z;

            // ������������� ������ ���� � ��������������� ��������� �������
            currentZone.transform.localScale = new Vector3(objectWidth, 1f, objectHeight);

            // ���������� ����
            currentZone.SetActive(true);

            
        }
    }
}
