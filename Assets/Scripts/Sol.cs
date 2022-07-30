using UnityEngine;

public class Sol : MonoBehaviour
{
    AspetSol aspetSol;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject heartPrefab;


    private void Start()
    {
        aspetSol = GameObject.FindObjectOfType<AspetSol>();
        SpawnObstacle();
        //SpawnCoins();
        SpawnCoin();
        SpawnHearts();
    }

 

    private void OnTriggerExit(Collider other)
    {
        aspetSol.PointSol();
        Destroy(gameObject, 2);
    

    }
    //Runner

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void SpawnObstacle()
    {
        //choisir un point au hasard pour afficher l'obstacle
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //afficher l'obstacle a la position'
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

    //public GameObject coinPrefab;

    public void SpawnCoins()
    {
        int coinsToSpawn = 10;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 5;
        return point;
    }

    void SpawnCoin()
    {
        //choisir un nombre de pieces alignees :
        int numCoin = Random.Range(0, 10);
        //choisir une forme 
        // 1 pour ligne directe
        // 2 pour une forme circulaire
        int formCoin = Random.Range(1,3);
        // choisir la position
        //2 pour gauche
        //3 pour milieu
        //4 pour droite
        int positionCoin = Random.Range(5, 8);

        Vector3 pos = new Vector3(0, 0, 0);

        pos = transform.GetChild(positionCoin).transform.position;

        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity, transform);

        if(formCoin == 1)
        {
            for (float i = 0f; i < numCoin; i += 1f)
            {

                pos = coin.transform.position;

                pos.z += i;

                coin = Instantiate(coinPrefab, pos, Quaternion.identity, transform);



            }

        }

        else 
        {
            for(float i = 0f; i< numCoin; i+=1f )
            {
                pos = coin.transform.position;

                pos.z += i;


                if (i < numCoin / 2)
                    pos.y += i ;
                else
                    pos.y -= numCoin -  i;

                coin = Instantiate(coinPrefab, pos, Quaternion.identity, transform);

            }
        
        }
        
        
        

    }

    void SpawnHearts()
    {

        int positionHeart = Random.Range(5, 8);

        System.Random r = new System.Random();

        float p = (float)  r.NextDouble();

        if(p < 0.1f)
        {
            Vector3 pos = transform.GetChild(positionHeart).transform.position;
            Instantiate(heartPrefab, pos, Quaternion.identity, transform);

        }

    }
}
