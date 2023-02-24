using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatalogList : MonoBehaviour
{
    public Transform parent;
    public GameObject catalogItemButton;
    public List<GameObject> catalogItems;
    public Transform spawnLocation;
    GridObjectCollection objectCollection;
    // Start is called before the first frame update
    void Start()
    {
        objectCollection = GetComponent<GridObjectCollection>();

        for(int i = 0; i < catalogItems.Count; i++)
        {
            GameObject temp = Instantiate(catalogItemButton, transform);
            temp.GetComponent<CatalogItem>().UpdateArtifact(catalogItems[i], spawnLocation, parent.transform);
        }

        objectCollection.UpdateCollection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
