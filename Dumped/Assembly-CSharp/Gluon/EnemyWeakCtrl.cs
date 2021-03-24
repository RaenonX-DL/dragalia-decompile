/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyWeakCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		protected EnemyCharacter _character;
		[CompilerGenerated]
		private float _priorityTargetRange_k__BackingField;
		private int _hp;
		private int _deadCount;
		public const int CHANGE_HP_MAX = 4;
		private int[] _changeHps;
		[CompilerGenerated]
		private int _whenDeadCenterCharacterActionId_k__BackingField;
		private Vector3 _offsetPos;
	
		// Properties
		public float priorityTargetRange { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int whenDeadCenterCharacterActionId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public EnemyWeakCtrl();
	
		// Methods
		public static void Initialize(GameObject go, float pTargetRange, int[] cHps);
		protected virtual void Initialize(float pTargetRange, int[] cHps);
		public bool isCenterCharacterExist();
		public int GetNextReviveHp();
		public virtual void Revive(int hp, int wdCenterCharacterActId);
		public virtual void Leave();
		public virtual void DeadPlayCenterCharacterAction();
		public void LateUpdate();
		private void SendWeakPointDead();
	}
}
