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
	public class ExtensionImageEffect : ImageEffectBase
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private int _imageEffectSubID;
		[SerializeField]
		[Tooltip]
		private int _attachmentID;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		protected Camera _attachCamera;
	
		// Properties
		public int imageEffectSubID { get; }
		public int attachmentID { get; }
	
		// Constructors
		public ExtensionImageEffect();
	
		// Methods
		public virtual void OnAttachCamera(Camera camera);
	}
}
