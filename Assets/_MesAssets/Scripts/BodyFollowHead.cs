using UnityEngine;

public class BodyFollowHead : MonoBehaviour
{
    [SerializeField] private Transform _tete = default;
    [SerializeField] float _verticalOffset;

    private void Update()
    {
        // D�place le body par rapport � la position de la t�te
        transform.position = _tete.position + Vector3.up * _verticalOffset;

        //Effectue la rotation en Y du body dans la m�me direction que la t�te
        transform.eulerAngles = new Vector3(0f, _tete.eulerAngles.y, 0f);
    }
}
