using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    void Awake()
    {
        if(controller != null && controller != this)
        {
            Destroy(this.gameObject);
            return;
        }

        controller = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
