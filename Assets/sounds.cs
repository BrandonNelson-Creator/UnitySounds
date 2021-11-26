using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public AudioSource Sound;
    public GameObject Win;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Sound!");
        Sound.Play();
        Win.SetActive(true);
        StartCoroutine(FinishCut());

    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(4);
        Win.SetActive(false);    }
}
