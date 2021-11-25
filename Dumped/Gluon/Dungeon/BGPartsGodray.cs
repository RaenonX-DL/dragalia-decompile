using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class BGPartsGodray : MonoBehaviour
	{
		[SerializeField]
		private float FadeOutStartDistance;

		[SerializeField]
		private float FadeOutEndDistance;

		private MeshCollider meshCollider;

		private float prevAlpha;

		private MaterialPropertyBlock[] materialPropertyBlockArray;

		private int programmableColorId;

		[NonSerialized]
		public float masterAlpha;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateFadeout()
		{
		}

		private void InitializeGodRay()
		{
		}

		private void InitializeMaterial()
		{
		}

		private void ApplyMaterialAlpha(float alpha)
		{
		}
	}
}
