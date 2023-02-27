using System;
using UnityEngine;

public class Subject : MonoBehaviour
{
    public static event Action<Vector3> OnButtonClicked;
    
    public void JumpOnClick() =>  OnButtonClicked?.Invoke(Vector3.up);
}
