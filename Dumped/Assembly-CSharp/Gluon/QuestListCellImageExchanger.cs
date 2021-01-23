/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestListCellImageExchanger : UiImageExchanger
	{
		// Fields
		[SerializeField]
		private Shader exchangeShader;
		[SerializeField]
		private string maskTextureShaderParamName;
		[SerializeField]
		private Texture exchangeMaskTexture;
		private List<Material> materialList;
	
		// Constructors
		public QuestListCellImageExchanger();
	
		// Methods
		public override void SetImage(int index, bool isOverrideSprite = false);
	}
}
