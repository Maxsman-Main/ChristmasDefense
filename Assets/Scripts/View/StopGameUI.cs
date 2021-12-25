using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameUI : MonoBehaviour, IShow
{
    public void ShowUI()
    {
        gameObject.SetActive(true);
    }
}
