using UnityEngine;
using UnityEngine.UIElements;

public class Hole_Script : MonoBehaviour
{
    public Transform[] Spots;
    private int index;
    public HoleGame_Manager HGmanager;

    public void Start()
    {
        transform.position = Spots[index].transform.position;
    }

    public void Update() //its gonna look crazy but this will somehow make each stage have its individual pathing of the scoring hole
    {
        switch (HGmanager.CurrentStage)
        {
            case HoleGame_Manager.Stages.Stage1:
                break;
        }
        if(index <= Spots.Length -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Spots[index].transform.position, 7f * Time.deltaTime);
            if (transform.position == Spots[index].transform.position)
            {
                index += 1;
            }
        }
        if(index == Spots.Length)
        {
            index = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Score_Keeper.Scoretotal += 100;
        }
    }
}
