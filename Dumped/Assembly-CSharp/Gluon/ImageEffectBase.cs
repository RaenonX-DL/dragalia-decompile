/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ImageEffectBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private int _imageEffectID;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private int _imageEffectSortID;
		[SerializeField]
		[Tooltip]
		private LodLevel _enableLodLevel;
	
		// Properties
		public int imageEffectID { get; set; }
		public int imageEffectSortID { get; set; }
		public LodLevel enableLodLevel { get; }
	
		// Constructors
		public ImageEffectBase();
	
		// Methods
		public virtual DepthTextureMode GetNeedDepthTextureMode();
		public virtual bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
