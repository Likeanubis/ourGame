using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    public GameObject player;
    

    public void resetPlayerPosition()
    {
        player.transform.position = new Vector3(177f, 0.6f, 177f);
        player.transform.rotation = Quaternion.identity;
    }
}
