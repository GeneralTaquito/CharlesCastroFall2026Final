using System.Threading;
using TMPro;
using UnityEngine;

public class HoleGame_Manager : MonoBehaviour
{
    private float timer;
    public TextMeshProUGUI Confirm;
    public GameObject Ball;

    public Stages CurrentStage = Stages.None;
    public enum Stages
    {
        None = 0,
        Stage1 = 1,
        Stage2 = 2,
        Stage3 = 3,
    }

    private void Start()
    {
        Confirm.gameObject.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CurrentStage = Stages.Stage1;
            Confirm.gameObject.SetActive(false);
            Invoke(nameof(Spawner),2f);
        }

        switch (CurrentStage)
        {
            case Stages.None:
                break;
            case Stages.Stage1:
                Debug.Log("Stage 1 Starts");
                break;
            case Stages.Stage2:
                Debug.Log("Stage 2 Starts");
                break;
            case Stages.Stage3:
                Debug.Log("Stage 3 Starts");
                break;
        }
    }


    void Spawner()
    {
        
    }


}
