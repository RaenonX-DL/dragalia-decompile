/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSlipCtrl
	{
		// Fields
		private float elapsedTime;
		[CompilerGenerated]
		private float _coef_k__BackingField;
		[CompilerGenerated]
		private Vector3 _slipVec_k__BackingField;
		[CompilerGenerated]
		private Vector3 _lastMoveVec_k__BackingField;
		[CompilerGenerated]
		private Vector3 _lastInputVec_k__BackingField;
		private bool start;
		private bool end;
		[CompilerGenerated]
		private bool _restart_k__BackingField;
		[CompilerGenerated]
		private bool _isActionMove_k__BackingField;
	
		// Properties
		public float coef { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 slipVec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 lastMoveVec { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 lastInputVec { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool restart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isActionMove { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CharacterSlipCtrl();
	
		// Methods
		public void Reset();
		public void Update(float delta, Vector3 moveVec, CharacterBase owner);
	}
}
