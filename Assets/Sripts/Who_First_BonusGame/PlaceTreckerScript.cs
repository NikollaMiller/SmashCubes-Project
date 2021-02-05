using UnityEngine;

public class PlaceTreckerScript : MonoBehaviour
{
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    [SerializeField] private Transform player3;
    [SerializeField] private Transform Finish;

    public int place;
    private float[] distance = new float[3];

    private void Update()
    {
       distance[0] = Vector3.Distance(player1.position, Finish.position);
       distance[1] = Vector3.Distance(player2.position, Finish.position);
       distance[2] = Vector3.Distance(player3.position, Finish.position);

        if (distance[0] < distance[1] && distance[0] < distance[2])
        {
            place = 2;
        }
        else if (distance[1] < distance[0] && distance[1] < distance[2])
        {
            place = 1;
        }
        else if (distance[2] < distance[0] && distance[2] < distance[1])
        {
            place = 3;
        }
        else 
        {
            place = 2;
        }
    }

}
