using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject theEnemy;
    public int Xpos;
    public int Ypos;
    public int enemyCount;

    public int enemyAdjust;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(EnemyDrop()); 
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < enemyAdjust){
            Xpos = Random.Range(11, -12);
            Ypos = Random.Range(7, -6);
            Instantiate(theEnemy, new Vector3(Xpos, 1, Ypos), Quaternion.identity);  //This quaternion corresponds to "no rotation" - the object is perfectly aligned with the world or parent axes.
            yield return new WaitForSeconds(4);
            enemyCount += 1;
        }
    }
  
}
