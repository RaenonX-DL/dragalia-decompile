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
	[Serializable]
	public class ColorData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Vector3 _color;
		[HideInInspector]
		[SerializeField]
		private float _colorPower;
		[HideInInspector]
		[SerializeField]
		private float _smoothSec;
	
		// Properties
		public Vector3 color { get; }
		public float colorPower { get; }
		public float smoothSec { get; }
	
		// Constructors
		public ColorData();
	}
}
