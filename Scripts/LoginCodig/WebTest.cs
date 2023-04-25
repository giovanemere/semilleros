using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using 
public class WebTest : MonoBehaviour
{
 
    IEnumerable Start()
    {
        WWW request = new WWW("http://localhost/Bakery/createUser.php");
        yield return request;
        Debug.Log(request.text);
    }
}
