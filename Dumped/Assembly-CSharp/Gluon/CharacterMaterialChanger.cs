/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterMaterialChanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private ChangeData[] changeDataArray;
	
		// Nested types
		[Serializable]
		public class MaterialData
		{
			// Fields
			public Material[] materials;
	
			// Constructors
			public MaterialData();
		}
	
		[Serializable]
		public class ChangeData
		{
			// Fields
			public string rendererPath;
			private Renderer targetRenderer;
			public MaterialData[] materialDataArray;
	
			// Constructors
			public ChangeData();
	
			// Methods
			public void Initialize(Transform rootNode);
			public void ChangeMaterials(int index);
		}
	
		// Constructors
		public CharacterMaterialChanger();
	
		// Methods
		private void Start();
		public void SetMaterial(int index);
	}
}
