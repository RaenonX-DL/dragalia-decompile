using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class QuestListCellImageExchanger : UiImageExchanger
	{
		[SerializeField]
		private Shader exchangeShader;

		[SerializeField]
		private string maskTextureShaderParamName;

		[SerializeField]
		private Texture exchangeMaskTexture;

		private List<Material> materialList;

		public override void SetImage(int index, bool isOverrideSprite = false)
		{
		}
	}
}
