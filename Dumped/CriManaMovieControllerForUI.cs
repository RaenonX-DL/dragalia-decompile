using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
public class CriManaMovieControllerForUI : CriManaMovieMaterial
{
	public Graphic target;

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
