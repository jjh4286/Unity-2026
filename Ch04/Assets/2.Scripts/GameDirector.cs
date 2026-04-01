using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        car = GameObject.Find("car_0");
        flag = GameObject.Find("flag_0");
        distance = GameObject.Find("Distance");      
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        //float length = flag.position.x - car.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance" + length.ToString("F2") + "m";
        //distance
    }
}
