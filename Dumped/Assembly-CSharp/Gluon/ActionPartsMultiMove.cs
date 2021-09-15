/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMultiMove : ActionParts
	{
		// Fields
		private readonly MultiMoveData _partsData;
		private State _state;
		private List<Vector3> _listTarget;
		private int _targetingCnt;
		private float _timer;
		private ActionMove _move;
		private int _moveProperty;
		private Vector3 _preForward;
	
		// Nested types
		public enum TargetType
		{
			FixedPosition = 0
		}
	
		public enum BaseType
		{
			AreaAnchor = 0,
			Owner = 1
		}
	
		public enum State
		{
			Idle = 0,
			Turn = 1,
			BeginMove = 2,
			Move = 3,
			EndMove = 4,
			Wait = 5,
			End = 6
		}
	
		// Constructors
		public ActionPartsMultiMove(ActionParts resource);
	
		// Methods
		public override void Clear();
		private void ProcClear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private void ProcTurn();
		private void ProcBeginMove();
		private void ProcMove(float delta);
		private void ProcEndMove();
		private void CreateTargetList();
	}
}
