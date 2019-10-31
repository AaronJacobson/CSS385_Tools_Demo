
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "enemy", menuName = "Enemy/FloatingEnemy")]
    public class EnemySO : ScriptableObject
    {
        public Sprite image;
        public float speed;

        public int health;
        public float size;
    }

    [CreateAssetMenu(fileName ="t2",menuName ="Friend")]
    public class FriendSO : ScriptableObject
    {
        public int health;
    }
}
