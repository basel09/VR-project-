using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject SlingshotBird;
    
    public Slingshot Slingshot;
    public float BirdDestructionTime = 5f;

    void Start()
    {

        SetNewBird();
    }

    void Update()
    {
        
    }



    public void SetNewBird()
    {
      

        GameObject bird = Instantiate(SlingshotBird, new Vector3(Slingshot.transform.position.x - 0.08f, Slingshot.transform.position.y + 3.82f, Slingshot.transform.position.z - 0.29f), Quaternion.identity);
        
        if (SlingshotBird.name == "YBird")
        {
            bird.transform.Rotate(-100, 0, 40);
        }
            bird.GetComponent<Bird>().DestructionTime = BirdDestructionTime;
            Slingshot.Bird = bird;
            Camera.main.GetComponent<MainCamera>().Bird = bird;

    

    


    }
}

  