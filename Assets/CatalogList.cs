using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CatalogList : MonoBehaviour
{
    public Transform parent;
    public GameObject catalogItemButton;
    public List<ArtifactSO> catalogItems;
    public Transform spawnLocation;
    GridObjectCollection objectCollection;

    public TMP_Text artifactName;
    public TMP_Text catalogNumber;
    public TMP_Text plotLocation;
    public TMP_Text artifactDescription;

    // Start is called before the first frame update
    void Start()
    {
        objectCollection = GetComponent<GridObjectCollection>();

        for(int i = 0; i < catalogItems.Count; i++)
        {
            GameObject temp = Instantiate(catalogItemButton, transform);
            temp.GetComponent<CatalogItem>().UpdateArtifact(catalogItems[i], spawnLocation, transform.parent);
        }

        objectCollection.UpdateCollection();
    }

    public void SetupSelectedArtifact(string name, string number, string plot, string description)
    {
        artifactName.text = name;
        catalogNumber.text = number;
        plotLocation.text = plot;
        artifactDescription.text = description;
    }
}
