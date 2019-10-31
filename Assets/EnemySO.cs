
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "enemy", menuName = "Enemy/FloatingEnemy")]
    public class EnemySO : ScriptableObject
    {
        public Sprite image;
        public float speed;
    }
}
