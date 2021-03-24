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
	public class CollisionTransform
	{
		// Fields
		public ActionCollisionPos _collisionPos;
		public Vector3 _ofsPos;
		public float _angle;
		public float _spaceLength;
		public SlotFrontType _slotFrontType;
		protected CharacterBase _owner;
		protected CharacterBase _attachChara;
		protected Vector3 _startPos;
		protected Vector3 _currentPos;
		protected Vector3 _prevPos;
		protected Vector3 _forward;
		protected Vector3 _startOwnerCenterPos;
		[CompilerGenerated]
		private float _forwardOffsetLength_k__BackingField;
		[CompilerGenerated]
		private bool _isDefaultForwardOffset_k__BackingField;
	
		// Properties
		public Vector3 StartPos { get; }
		public Vector3 CurrentPos { get; }
		public Vector3 PrevPos { get; }
		public Vector3 Forward { get; }
		public Vector3 StartOwnerCenterPos { get; }
		protected float forwardOffsetLength { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool isDefaultForwardOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum SlotFrontType
		{
			None = 0,
			Follow = 1,
			FollowY = 2
		}
	
		// Constructors
		public CollisionTransform();
	
		// Methods
		public virtual void Clear();
		public void Calc(CharacterBase owner, CharacterBase attachChara, GameObject target = null, bool notUseOwnerForward = false);
		public void Calc(Vector3 startPos, Vector3 forward, GameObject target = null);
		private void CalcStartTransform(Vector3 basePos, Vector3 forward, GameObject target = null);
		private void CalcSlotTranfrom(string slotName);
		public void SetCurrentPosFromAdditionalAttack(Vector3 pos);
	}
}
