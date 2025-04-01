using UnityEngine;
using System;
using System.Collections;
public class CollideCharacter : MonoBehaviour
{

    public GameObject panelTask1;
    public GameObject zakazchik;
    public GameObject mestoZakazchika;
    //public GameObject strelkaZakazchika;



    private float[,] positions = {
        { -166.9f, 2f, 87.8f }, //позиция 1
        { -109.1f, 2f, 90.2f },//позиция 2
        { -108.1f, 2f, 150.3f },//позиция 3
        { 11.7f, 2f, 158.7f },//позиция 4
        { 19.1f, 2f, 87.1f },//позиция 5
        { -166.9f, 2f, 145.5f },//позиция 6
    };
    [NonSerialized] public static Vector3 myLocation;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            StartTask();
            //strelkaZakazchika.SetActive(true);
        }
    }


    public void StartTask()
    {
        panelTask1.SetActive(true);
        CreateZakazchikAtRandomPosition();
        StartCoroutine(DeletePanel());
    }

    //функция создания спавна рандомного места закзчика
    private void CreateZakazchikAtRandomPosition()
    {
        // Выбор случайного индекса из массива позиций
        int randomIndex = UnityEngine.Random.Range(0, 6);
        

        // Получаем координаты для создания объекта
        Vector3 spawnPosition = new Vector3(positions[randomIndex, 0], positions[randomIndex, 1], positions[randomIndex, 2]);
        myLocation = spawnPosition;
        // Создаем объект на выбранной позиции
        //Instantiate(zakazchik, spawnPosition, Quaternion.identity);
        zakazchik.transform.position = spawnPosition;
        zakazchik.SetActive(true);
        TargetLocationForComplTask();
    }

    //функция создания места для заказчика
    private void TargetLocationForComplTask()
    {
        int randomIndex = UnityEngine.Random.Range(0, positions.GetLength(0));
        Vector3 spawnPosition = new Vector3(positions[randomIndex, 0], positions[randomIndex, 1], positions[randomIndex, 2]);

        // Если необходимо проверить на совпадение с myLocation
        if (Vector3.Distance(spawnPosition, myLocation) < 0.1f)
        {
            randomIndex = (randomIndex + 1) % positions.GetLength(0);
            spawnPosition = new Vector3(positions[randomIndex, 0], positions[randomIndex, 1], positions[randomIndex, 2]);
        }

        //Instantiate(mestoZakazchika, spawnPosition, Quaternion.identity);
        mestoZakazchika.transform.position = spawnPosition;
    }
    private IEnumerator DeletePanel()
    {
        yield return new WaitForSeconds(5);
        panelTask1.SetActive(false);
    }
}
