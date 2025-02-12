using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4;  
    private float timer = 0;
    public float heightOffset = 10;

    private LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        NekoScript.gameStarted = false;
     
    }

    // Update is called once per frame
    void Update()
    {

        if (!NekoScript.gameStarted) return; //variable comes form NekoScript

        calcSpawnRate();
        if(timer < spawnRate) {
            timer = timer + Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint),0), transform.rotation);
    }

    void calcSpawnRate() {
        if (logic.playerScore == 15){
            spawnRate = 3;
        }else if(logic.playerScore == 25) {
            spawnRate = 2.5f;
        }else if(logic.playerScore == 35) {
            spawnRate = 2;
        }else if(logic.playerScore == 50) {
            spawnRate = 1.5f;
        }else if(logic.playerScore == 100) {
            spawnRate = 1;
        }
    }
}
