using System.Collections;
using UnityEngine;

public class StillBird : MonoBehaviour
{
    public float WaitForSeconds;

    IEnumerator Start()
    {
         yield return new WaitForSeconds(WaitForSeconds);
    }

 
    }
