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
	public class TanatosHourglassDropData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _positionNum;
		[HideInInspector]
		[SerializeField]
		private Vector3[] _positions;
	
		// Properties
		public int positionNum { get; }
		public Vector3[] positions { get; }
	
		// Constructors
		public TanatosHourglassDropData();
	}
}
