/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[AddComponentMenu]
	[HelpURL]
	public class ActionPartsEffect : ActionParts
	{
		// Fields
		[SerializeField]
		private EffectData _data;
	
		// Properties
		public override PartsData data { get; }
	
		// Nested types
		public enum InspectorDisplayType
		{
			Normal = 0,
			HitEffect = 1
		}
	
		// Constructors
		public ActionPartsEffect();
	}
}
