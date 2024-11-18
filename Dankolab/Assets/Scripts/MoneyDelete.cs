using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyDelete : MonoBehaviour
{
    public void Awake()
    {
        StartCoroutine(Remove());
    }

    IEnumerator Remove()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
