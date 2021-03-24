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
	public class ImageEffectAttachment : ImageEffectBase
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private int _attachmentID;
		private GameObject _attachImageEffectPrefab;
	
		// Properties
		public int attachmentID { get; }
	
		// Constructors
		public ImageEffectAttachment();
	
		// Methods
		public bool AttachImageEffect(string prefabPath);
	}
}
