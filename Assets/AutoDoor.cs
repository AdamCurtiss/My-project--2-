using System.Collections;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
   
    public enum DoorState
    {
        Closed,
        Closing,
        Open,
        Opening,
    }
    DoorState State;
    public float Duration = 1.0f;
    public GameObject Hinge;
    float Timeline;



    private void OnTriggerEnter(Collider other)
    {
        switch (State)
        {
            case DoorState.Closed:
                Timeline = Duration;
                State = DoorState.Opening;
                break;
            case DoorState.Open:
                Timeline = Duration;
                State = DoorState.Closing;

                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    
    
    {
        switch (State)
        {
            case DoorState.Opening:
                Hinge.transform.Rotate(0.0f, (90.0f / Duration) * Time.deltaTime, 0.0f);
                Timeline -= Time.deltaTime;
                if (Timeline <= 0.0f)
                {
                    State = DoorState.Open;
                }
                break;
            case DoorState.Closing:
                Hinge.transform.Rotate(0.0f, (-90.0f / Duration) * Time.deltaTime, 0.0f);
                Timeline -= Time.deltaTime;
                if (Timeline <= 0.0f)
                {
                    State = DoorState.Closed;
                }

                break;
            default:
                break;

        }
    }
}


    
        


