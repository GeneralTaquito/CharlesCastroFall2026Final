using UnityEngine;

public class Hole3_Script : MonoBehaviour
{
    Vector3 rightpos = new Vector3(-15f, 11f, 5f);
    Vector3 leftpos = new Vector3(-15f, 11f, -5f);
    Vector3 targetpos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dice"))
        {
            Score_Keeper.Scoretotal += 200;
        }
    }

    private void Start() //setting holes position to the right and making the target position for the movetowards to the left 
    {
        transform.position = rightpos;
        targetpos = leftpos;
    }
    private void Update() //movetowards either position perpetually
    {
        transform.position = Vector3.MoveTowards(transform.position, targetpos, 7f * Time.deltaTime);

        if (transform.position == targetpos) // swapping target positions to either side when it reaches t
        {
            if (targetpos == leftpos)
            {
                targetpos = rightpos;
            }
            else
            {
                targetpos = leftpos;
            }
        }
    }
}
