/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SecondElementsUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		public static readonly int SECOUND_ELEMENTS_NUM;
		private float[] _origin;
		private float[] _limit;
		[SerializeField]
		private float[] _point;
		[SerializeField]
		private float[] _power;
		private ElementType _selectedElement;
		[SerializeField]
		private State _state;
		private int _actionId;
	
		// Nested types
		public enum ElementType
		{
			Curse = 0,
			Bless = 1,
			Wind = 2,
			Fire = 3,
			None = 99
		}
	
		public enum State
		{
			Init = 0,
			Idle = 1,
			Running = 2,
			Groggy = 3,
			Regain = 4
		}
	
		// Constructors
		public SecondElementsUniqueCtrl();
		static SecondElementsUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void Setup(Setup2ndElementsData resource);
		public void OnStart();
		public override void FastUpdate();
		private void Ready();
		public void OnDamage(CollisionHitAttribute hitAttr, int damage);
		public bool CheckGroggy();
		public bool Regain();
		public bool IsValidElement(ElementType element);
		public bool IsValidAnyElement();
		public void SetCurrentPoint(ElementType element, float value);
		public void SubCurrentPoint(ElementType element, float value);
		public float GetCurrentPoint(ElementType element);
		public void SetLimitPoint(ElementType element, float value);
		public float GetLimitPoint(ElementType element);
		public float GetRate(ElementType element);
		public void ShowSecondElementsGaugeUI();
		public void SendGroggy(ElementType element);
		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent);
		public override void OnChangeState(CharacterState state);
	}
}
