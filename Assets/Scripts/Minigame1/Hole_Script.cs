using UnityEngine;
using UnityEngine.UIElements;

public class Hole_Script : MonoBehaviour
{
    public Transform[] Spots;
    public int index;
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
                if (index == 1)
                {
                    transform.position = Vector3.MoveTowards(transform.position, Spots[index].transform.position, 5f * Time.deltaTime);
                    if (transform.position == Spots[index].transform.position)
                    {
                        index = 3;
                    }
                }
                if (index == 3)
                {
                    index = 1;
                }
                break;
            case HoleGame_Manager.Stages.Stage2:
                if (index <= Spots.Length - 1)
                {
                    transform.position = Vector3.MoveTowards(transform.position, Spots[index].transform.position, 5f * Time.deltaTime);
                    if (transform.position == Spots[index].transform.position)
                    {
                        index += 1;
                    }
                }
                if (index == Spots.Length)
                {
                    index = 0;
                }
                break;
            case HoleGame_Manager .Stages.Stage3:
                break;
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
