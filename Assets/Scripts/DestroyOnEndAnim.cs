using UnityEngine;

namespace Solid
{
    public class DestroyOnEndAnim : MonoBehaviour
    {
        public void DestroyGameobject()
        {
            Destroy(gameObject);
        }
    }
}