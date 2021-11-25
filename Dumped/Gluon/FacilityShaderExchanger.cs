using System;
using UnityEngine;

namespace Gluon
{
	public class FacilityShaderExchanger : MonoBehaviour
	{
		[Serializable]
		private struct TargetInfo
		{
			public string targetShaderName;

			public Shader exchangeShader;

			public string[] transferTextureParamNameArray;

			public bool createNewMaterial;
		}

		[SerializeField]
		protected GameObject targetObj;

		[SerializeField]
		private TargetInfo[] targetInfoArray;

		[SerializeField]
		private bool exchangeOnStart;

		[SerializeField]
		private bool exchangeAllChildren;

		private void Start()
		{
		}

		public void SetShader()
		{
		}

		public void SetMaterialShader(Renderer targetRenderer)
		{
		}
	}
}
