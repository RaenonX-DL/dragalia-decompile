/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestListCellShaderExchanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected GameObject targetObj;
		[SerializeField]
		private Shader exchangeShader;
		[SerializeField]
		private string maskTextureShaderParamName;
		[SerializeField]
		private Texture exchangeMaskTexture;
		[SerializeField]
		private Material textMaterial;
		[SerializeField]
		private bool exchangeOnStart;
		[SerializeField]
		private bool exchangeAllChildren;
		[SerializeField]
		private List<Image> ignoreChildrenList;
		private Material exchangeMaterial;
		private List<Material> createdExchangeMaterials;
		private List<Material> materialList;
		private const string mainTextureShaderParamName = "_MainTex";
		private const string alphaTextureShaderParamName = "_AlphaTex";
		private const string topOutsideClipRatioShaderParamName = "_TopOutsideClipRatio";
		private const string bottomOutsideClipRatioShaderParamName = "_BottomOutsideClipRatio";
	
		// Constructors
		public QuestListCellShaderExchanger();
	
		// Methods
		private void Start();
		public void SetShaderToChildFlash(GameObject obj, bool isShareMaterial = true, bool isIgnoreImageWithSameShader = false);
		private bool ShouldIgnoreImage(Image image);
		public void SetShader(bool isShareMaterial = true, bool isIgnoreImageWithSameShader = false);
		public void SetShaderClipRatioParameter(Material mat, bool isAlphaA8 = true);
		public void SetMaterialShader(Image targetImage, bool isShareMaterial = true);
		private Material SetMaterialShader(Material material, bool isShareMaterial = true);
		public Texture GetExchangeMaskTexture();
	}
}
