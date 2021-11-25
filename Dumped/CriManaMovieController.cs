using UnityEngine;

[AddComponentMenu("CRIWARE/CriManaMovieController")]
public class CriManaMovieController : CriManaMovieMaterial
{
	public Renderer target;

	public bool useOriginalMaterial;

	private Material originalMaterial;

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnMaterialAvailableChanged()
	{
	}
}
