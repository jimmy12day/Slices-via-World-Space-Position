using UnityEngine;

public class HeightAjust : MonoBehaviour
{
    public void HeighAjust(float z)
    {
        transform.position = new Vector3(transform.position.x, z, transform.position.z);
    }
}
