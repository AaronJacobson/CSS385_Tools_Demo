using Assets;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed = 4;


    public EnemySO enemySo;

    private Quaternion originalOrientation;
    // Start is called before the first frame update
    void Start()
    {
        //this.movementSpeed = enemySo.speed;
        //this.transform.localScale = new Vector3(enemySo.size, enemySo.size, 1);

        this.originalOrientation = transform.rotation;
        GetComponent<SpriteRenderer>().sprite = this.enemySo.image;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
        transform.rotation = this.originalOrientation;
    }
}
