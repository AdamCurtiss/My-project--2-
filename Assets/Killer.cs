using UnityEngine;

public class Killer : MonoBehaviour
{
    public GameObject Enemy;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Destroy(Enemy);
        }
    }
}
