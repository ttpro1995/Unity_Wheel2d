using UnityEngine;
using System.Collections;

public class CreateItem : MonoBehaviour {

    public GameObject itemObj;
    private Transform parentTrans;
    private Quaternion identityQuat;
    private Vector3 parentPos;

	// Use this for initialization
	void Start () {
        parentTrans = transform;
        identityQuat = Quaternion.identity;
        parentPos = parentTrans.position;
        createItemOnCircle(8);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void initFourItem()
    {
        Vector3 position;
        GameObject newItem;


        
       
        position = new Vector3(parentPos.x + 3.5f, parentPos.y + 0.0f);
        newItem = (GameObject)Instantiate(itemObj, position, identityQuat);
        newItem.name = "mèo đen phải";
        newItem.transform.parent = transform;//attach it to parent

        position = new Vector3(parentPos.x, parentPos.y - 3.5f);
        newItem = (GameObject)Instantiate(itemObj, position, Quaternion.AngleAxis(90, new Vector3(0, 0, 1)));
        newItem.name = "mèo đen dưới";
        newItem.transform.parent = transform;//attach it to parent

        position = new Vector3(parentPos.x - 3.5f, parentPos.y + 0.0f);
        newItem = (GameObject)Instantiate(itemObj, position, Quaternion.AngleAxis(90+90, new Vector3(0, 0, 1)));
        newItem.name = "mèo đen trái";
        newItem.transform.parent = transform;//attach it to parent
        
        position = new Vector3(parentPos.x, parentPos.y + 3.5f);
        newItem = (GameObject)Instantiate(itemObj, position, Quaternion.AngleAxis(90+90+90, new Vector3(0, 0, 1)));
        newItem.name = "mèo đen trên ";
        newItem.transform.parent = transform;//attach it to parent
    }

    void initOneItem()
    {
       
        GameObject newItem = (GameObject)Instantiate(itemObj, parentTrans.position, identityQuat);
        newItem.name = "Con mèo kêu gâu gâu";
        newItem.transform.parent = transform;//attach it to parent
    }

//    function RandomCircle(center:Vector3, radius:float): Vector3 { // create random angle between 0 to 360 degrees
//    var ang = Random.value * 360;
//    var pos: Vector3;
//    pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
//    pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
//    pos.z = center.z;
//    return pos; 
//}

    Vector3 onCircle(Vector3 center, float radius, int ang)
    {
        Vector3 pos;
        ang = ang + 90;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos; 
    }

    void createItemOnCircle(int num)
    {
        Vector3 position;
        GameObject newItem;
        int angle = 0;
        int inc = 360 / num;
        float radius = 3.5f;
        Vector3 center = transform.position;//parent position



        for (int i = 0; i < num; i++)
        {
            position = onCircle(center,radius,angle);
            newItem = (GameObject)Instantiate(itemObj, position, Quaternion.AngleAxis(-angle, new Vector3(0, 0, 1)));
            newItem.name = "mèo đen "+angle;
            newItem.transform.parent = transform;//attach it to parent
            angle = angle + inc;
        }
    }
}
