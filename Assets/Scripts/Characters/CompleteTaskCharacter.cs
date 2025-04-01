using UnityEngine;
using System;
using System.Collections;
public class CompleteTaskCharacter : MonoBehaviour
{
    public GameObject panelTaskCompl;
    public GameObject strelka;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameObject.transform.position = new Vector3(0, -10, 0);
            strelka.SetActive(false);
            panelTaskCompl.SetActive(true);
            StartCoroutine(DeletePanel());
        }
    }
    private IEnumerator DeletePanel()
    {
        yield return new WaitForSeconds(5);
        panelTaskCompl.SetActive(false);
        gameObject.SetActive(false);

    }

}
