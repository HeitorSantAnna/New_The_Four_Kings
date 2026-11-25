using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController gameController {get; private set; }

    void Awake()
    {
        if(gameController != null && gameController != this)
        {
            Destroy(gameObject);

            return;
        }

        gameController = this;

        DontDestroyOnLoad(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
