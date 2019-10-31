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
        this.originalOrientation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
        transform.rotation = this.originalOrientation;
    }
}
