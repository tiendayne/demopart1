using UnityEngine;  // Thêm dòng này để Unity nhận diện MonoBehaviour

public class ShowLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");  // In ra thông báo khi game bắt đầu
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount);  // In ra số frame hiện tại
    }
}
