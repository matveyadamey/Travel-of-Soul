using UnityEngine;

public class Collectioner : MonoBehaviour
{
    public static int stars;
    [SerializeField] GameObject effect;
	private void Start()
	{
        stars = 0;
	}
	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "star")
        {
            var parent = other.gameObject.transform.parent;
            var child = parent.GetChild(0);
            var eff=Instantiate(effect, child.transform);
            eff.transform.parent = null;
            stars++;
            Destroy(parent.gameObject);
        }
    }
}
