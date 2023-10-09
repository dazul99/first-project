using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int numberOfPaws = 4;
    [SerializeField] private string name;

    private void Start()
    {
        Debug.Log($"{name} tiene {numberOfPaws} patas");
    }
}
