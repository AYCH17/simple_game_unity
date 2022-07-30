
using UnityEngine;

public class AspetSol : MonoBehaviour
{
    public GameObject sol;
    Vector3 nextSpawnPoint;

   public void PointSol()
    {
       GameObject temp = Instantiate(sol, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            PointSol();
        }
    }

   
}
