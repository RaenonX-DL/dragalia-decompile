/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SyncWithParentColor : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private bool ignoreAlpha;
		private Image parentImage;
		private Image image;
		private Color originalImageColor;
		private UnityEngine.UI.Text text;
		private Color originalTextColor;
		private CircleOutline outline;
		private Color originalOutlineColor;
	
		// Constructors
		public SyncWithParentColor();
	
		// Methods
		private void Start();
		private void LateUpdate();
	}
}
