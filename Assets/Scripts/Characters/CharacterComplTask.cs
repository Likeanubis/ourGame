using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.FilePathAttribute;

public class CharacterComplTask : MonoBehaviour
{
    public GameObject myStrelka;
    public GameObject strelkaMesta;
    public GameObject mestoZakazchika;

    private void OnEnable()
    {
        myStrelka.SetActive(true);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //gameObject.transform.position = new Vector3(0, -50f, 0);
            myStrelka.SetActive(false);
            strelkaMesta.SetActive(true);
            gameObject.SetActive(false);
            mestoZakazchika.SetActive(true);
        }
    }
}
