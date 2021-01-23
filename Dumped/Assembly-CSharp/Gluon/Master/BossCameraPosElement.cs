/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class BossCameraPosElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _PosX;
		[SerializeField]
		private float _PosZ;
		[SerializeField]
		private float _RotY;
	
		// Properties
		public int Id { get; }
		public float PosX { get; }
		public float PosZ { get; }
		public float RotY { get; }
	
		// Constructors
		public BossCameraPosElement();
	}
}
