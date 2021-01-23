/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SwitchingTextureData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _preTextureIdx;
		[HideInInspector]
		[SerializeField]
		private int _postTextureIdx;
	
		// Properties
		public int preTextureIdx { get; }
		public int postTextureIdx { get; }
	
		// Constructors
		public SwitchingTextureData();
	}
}
