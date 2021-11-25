using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VertexMesh : BaseMeshEffect
{
	[SerializeField]
	[Header("é\u00a0\u0082ç\u0082¹ã\u0081®æ­ªã\u0081¿è·\u009dé\u009b¢")]
	public List<Vector3> offsets;

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void ModifyVertices(List<UIVertex> vertexList)
	{
	}
}
