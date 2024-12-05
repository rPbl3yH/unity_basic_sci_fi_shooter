using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Класс. Совокупность полей и методов
public class ShootInput : MonoBehaviour
{
    //Поле. Хранилище информации
    public ShootComponent ShootComponent;
    
    //Метод.Алгоритм действий.
    public void OnShoot(InputValue value)
    {
        Debug.Log("Shoot!");
        ShootComponent.Shoot();
    }
}