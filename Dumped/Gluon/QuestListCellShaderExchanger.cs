using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestListCellShaderExchanger : MonoBehaviour
	{
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

		private void Start()
		{
		}

		public void SetShaderToChildFlash(GameObject obj, bool isShareMaterial = true, bool isIgnoreImageWithSameShader = false)
		{
		}

		private bool ShouldIgnoreImage(Image image)
		{
			return default(bool);
		}

		public void SetShader(bool isShareMaterial = true, bool isIgnoreImageWithSameShader = false)
		{
		}

		public void SetShaderClipRatioParameter(Material mat, bool isAlphaA8 = true)
		{
		}

		public void SetMaterialShader(Image targetImage, bool isShareMaterial = true)
		{
		}

		private Material SetMaterialShader(Material material, bool isShareMaterial = true)
		{
			return null;
		}

		public Texture GetExchangeMaskTexture()
		{
			return null;
		}
	}
}
