using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatalogItem : MonoBehaviour
{

    ArtifactSO artifact;
    Transform spawnLocation;
    Transform objectParent;
    // Start is called before the first frame update
    public void UpdateArtifact(ArtifactSO newArtifact, Transform spawnLocation, Transform parent)
    {
        artifact = newArtifact;
        this.spawnLocation = spawnLocation;
        this.objectParent = parent;
    }

    public void CreateArtifact()
    {
        if (Instancer.activeArtifact != null)
        {
            Destroy(Instancer.activeArtifact);
        }
        Instancer.activeArtifact = Instantiate(artifact.artifactPrefab, spawnLocation.position, spawnLocation.rotation, spawnLocation);

        objectParent.GetComponentInChildren<CatalogList>().SetupSelectedArtifact(artifact.artifactName, artifact.catalogNumber, artifact.siteOfDiscovery, artifact.artifactDescription);
    }
}
