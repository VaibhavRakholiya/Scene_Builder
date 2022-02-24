using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_Button : MonoBehaviour
{
    // Start is called before the first frame update
    private int index;
    private Button button;
    void Start()
    {
        index = this.transform.GetSiblingIndex();
        button = this.GetComponent<Button>();
        button.onClick.AddListener(onClickHandle);
        RawImage item_image = this.transform.GetChild(0).GetComponent<RawImage>();
        string path = "Item_Images/" + index.ToString();
        item_image.texture = Resources.Load<Texture>(path);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onClickHandle()
    {
        GridBuildingSystem3D.Instance.PickupItem(index);
        Debug.Log("Pressing.");
    }
}
