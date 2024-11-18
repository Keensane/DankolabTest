using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyDelete : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Remove());
    }

    IEnumerator Remove()
    {
        yield return new WaitForSeconds(1.8f);
        Destroy(gameObject);
    }
}
