/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MiasmaUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private float _timer;
		public const float POINT_MAX = 10000f;
		[SerializeField]
		private float _point;
		private float _addPointSpeed;
		private float _waitTimeForAuto;
		private int _actionId;
		private string _effName;
		private const string effKey = "aura_miasma";
		private string _beginSe;
		private string _endSe;
		[CompilerGenerated]
		private bool _IsPointSync_k__BackingField;
		[CompilerGenerated]
		private float _PointSyncDelayTime_k__BackingField;
	
		// Properties
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float point { get; private set; }
		private bool IsPointSync { [CompilerGenerated] get; [CompilerGenerated] set; }
		private float PointSyncDelayTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Start = 1,
			Run = 2,
			BoostBegin = 3,
			Boosting = 4,
			BoostEnd = 5,
			Wait = 6,
			Abort = 7
		}
	
		// Constructors
		public MiasmaUniqueCtrl();
	
		// Methods
		private void Reset();
		public override void Initialize();
		private void Update();
		private void ProcStart();
		private void ProcRun();
		private void ProcBoostBegin();
		private void ProcBoosting();
		private void ProcBoostEnd();
		private void ProcAbort();
		public void OnAbort();
		public void Setup(int actionId, float addPointSpeed, float waitTimeForAuto);
		public void SetupEffect(string effName, string beginSe, string endSe);
		public void SetPoint(float value);
		public void AddPoint(float value, bool fromEventSkill = false);
		public void OnReceiveMiasmaEvent(CharacterSpecialState state);
		public void SendMiasmaGaugeChangeEvent(float value);
		public void SendMiasmaGaugeChangeRequestEvent(float addValue);
	}
}
