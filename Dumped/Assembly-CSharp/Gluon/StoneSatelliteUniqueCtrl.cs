/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoneSatelliteUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private float STICK_SPACE;
		[CompilerGenerated]
		private List<EnemyCharacter> _childCharacter_k__BackingField;
		private Vector3 _basePosition;
		private Vector3[] _linePositions;
		[CompilerGenerated]
		private float _childRadius_k__BackingField;
		private Vector2[] _baseSpeed;
		private PositionStyle _posStyle;
		[CompilerGenerated]
		private bool _isMoveing_k__BackingField;
		private List<ActionMove> _actMoves;
	
		// Properties
		public List<EnemyCharacter> childCharacter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float childRadius { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isMoveing { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum PositionStyle
		{
			none = 0,
			stick = 1,
			parade = 2,
			target = 3,
			moveStick = 4
		}
	
		// Constructors
		public StoneSatelliteUniqueCtrl();
	
		// Methods
		public override void FastUpdate();
		private void FixedUpdate();
		public override void Initialize();
		public void SetPositionStyle(PositionStyle style, float tempoScale = 1f);
		public void TargetMove(CharacterBase chara, Vector3 target, float duration);
		public void SetStickMove(float duration);
		private void UpdateMove();
		private void FixedUpdateMove();
		private Vector3 CalcChildPosition(int no);
		public void ProductionOption(int childActionId, float tempoScale = 1f);
		public void ChildInvincible(bool set);
		public void ChildFullHP();
	}
}
