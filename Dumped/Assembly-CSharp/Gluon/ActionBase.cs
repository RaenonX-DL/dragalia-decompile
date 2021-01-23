/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionBase : ICollideCallback
	{
		// Fields
		public int _id;
		private const string profilerDispString = "";
		private const string profilerDispActionString = "";
		[CompilerGenerated]
		private int _skillId_k__BackingField;
		protected bool _autoDelete;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _creator_k__BackingField;
		private bool _isStarted;
		protected bool _isFinished;
		[CompilerGenerated]
		private float _startTime_k__BackingField;
		protected float _totalTime;
		protected bool startExceptTime;
		private Action<ActionBase> _finishCallback;
	
		// Properties
		public int skillId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool autoDelete { get; }
		public CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CharacterBase creator { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isStarted { get; protected set; }
		public bool isFinished { get; }
		public float startTime { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public ActionBase();
	
		// Methods
		public virtual string GetProfilerDispString();
		public virtual void Reset();
		public virtual void Initialize(CharacterBase chara);
		public virtual void Clear();
		public virtual RunActionParameterBase CreateRunActionParameter();
		public virtual void SetRunActionParameter(RunActionParameterBase param);
		public virtual void Start();
		protected virtual void OnStart();
		protected virtual void OnFinish();
		public virtual bool Update(float delta);
		protected virtual bool IsMatchExecuteCondition();
		public virtual void FixedUpdate(float delta);
		protected virtual bool OnUpdate(float delta);
		protected virtual bool OnFixedUpdate(float delta);
		public void Finish();
		public virtual void Stop();
		public void SetActionFinished();
		public virtual void RemoveSelf();
		public virtual void SetCreator(CharacterBase creator);
		public virtual void SetSkillId(int id);
		public void SetFinishCallback(Action<ActionBase> callback);
		public virtual void OnCollided(GameObject target, bool isPropagation);
		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public virtual void OnNotCollided(CharacterBase chara);
		public virtual void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent);
		public bool IsExcept(CharacterBase chara);
	}
}
