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
	public class SceneShaderSettings : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public SceneRichShaderData sceneRichShaderData;
		[HideInInspector]
		public BackgroundShaderParameter backgroundShaderParameter;
		[HideInInspector]
		public CharaShaderParameter charaShaderParameter;
		[CompilerGenerated]
		private delegateChangedBackgroundShaderParameter eventChangedBackgroundShaderParameter;
		[CompilerGenerated]
		private delegateChangedCharaShaderParameter eventChangedCharaShaderParameter;
	
		// Events
		public event delegateChangedBackgroundShaderParameter eventChangedBackgroundShaderParameter {
			add;
			remove;
		}
		public event delegateChangedCharaShaderParameter eventChangedCharaShaderParameter {
			add;
			remove;
		}
	
		// Nested types
		public delegate void delegateChangedBackgroundShaderParameter();
	
		public delegate void delegateChangedCharaShaderParameter();
	
		// Constructors
		public SceneShaderSettings();
	
		// Methods
		public virtual void OnChangedBackgroundShaderParameter();
		public virtual void OnChangedCharaShaderParameter();
		private void Awake();
	}
}
