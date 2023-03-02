using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArtifactData", menuName = "ArtifactTools/ArtifactData", order = 0)]
public class ArtifactSO : ScriptableObject
{
    public GameObject artifactPrefab;
    public string artifactName;
    public string catalogNumber;
    public string siteOfDiscovery;
    public string artifactDescription;
}
