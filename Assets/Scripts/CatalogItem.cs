using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatalogItem : MonoBehaviour
{

    GameObject artifact;
    Transform spawnLocation;
    Transform parent;
    // Start is called before the first frame update
    public void UpdateArtifact(GameObject gameObject, Transform spawnLocation, Transform parent)
    {
        artifact = gameObject;
        this.spawnLocation = spawnLocation;
        this.parent = parent;
    }

    public void CreateArtifact()
    {
        if (Instancer.activeArtifact != null)
        {
            Destroy(Instancer.activeArtifact);
        }
        Instancer.activeArtifact = Instantiate(artifact, spawnLocation.position, spawnLocation.rotation, parent);
    }
}
