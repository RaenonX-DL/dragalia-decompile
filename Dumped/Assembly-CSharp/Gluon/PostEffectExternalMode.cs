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
	public class PostEffectExternalMode : MonoBehaviour
	{
		// Fields
		private CacheCamera _cacheCamera;
		private Camera _postEffectCamera;
		private PostEffect _postEffect;
	
		// Constructors
		public PostEffectExternalMode();
	
		// Methods
		private void Awake();
		private void LateUpdate();
		public virtual DepthTextureMode GetNeedDepthTextureMode();
	}
}
