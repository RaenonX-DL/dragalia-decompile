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
	public class ImageEffectPlayer : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private bool enableAlpha;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private List<ImageEffectBase> _imageEffectList;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private List<ImageEffectBase> _imageEffectWorkList;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private PostEffectExternalMode[] _postEffectExternalModeArray;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private ImageEffectAttachment[] _imageEffectAttachmentArray;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private Material material;
		private Camera _cacheCamera;
		private const int IMAGEEFFECT_SORTSCALE = 100;
		private const float OUTLINE_FOV_BASE = 30f;
	
		// Constructors
		public ImageEffectPlayer();
	
		// Methods
		public bool AddImageEffect(ImageEffectBase imageEffectBase);
		private void Awake();
		private void Start();
		private void OnDisable();
		private void OnPreRender();
		private void OnRenderImage(RenderTexture source, RenderTexture destination);
	}
}
