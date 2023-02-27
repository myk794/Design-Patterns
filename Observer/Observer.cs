using UnityEngine;

public class Observer : MonoBehaviour
{
    private Rigidbody rb;
    
    public void Awake() => rb = transform.GetComponent<Rigidbody>();
    
    private void Start() =>  Subject.OnButtonClicked += Move;
    
    private void OnDestroy() =>  Subject.OnButtonClicked -= Move;
    
    private void Move(Vector3 direction) => rb.AddForce(direction*100f);
}
