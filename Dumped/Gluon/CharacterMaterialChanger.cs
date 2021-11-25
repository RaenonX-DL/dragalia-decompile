using System;
using UnityEngine;

namespace Gluon
{
	public class CharacterMaterialChanger : MonoBehaviour
	{
		[Serializable]
		public class MaterialData
		{
			public Material[] materials;
		}

		[Serializable]
		public class ChangeData
		{
			public string rendererPath;

			private Renderer targetRenderer;

			public MaterialData[] materialDataArray;

			public void Initialize(Transform rootNode)
			{
			}

			public void ChangeMaterials(int index)
			{
			}
		}

		[SerializeField]
		private ChangeData[] changeDataArray;

		private void Start()
		{
		}

		public void SetMaterial(int index)
		{
		}
	}
}
