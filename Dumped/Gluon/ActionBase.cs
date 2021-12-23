using System;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionBase : ICollideCallback
	{
		public int _id;

		private const string profilerDispString = "";

		private const string profilerDispActionString = "";

		protected bool _autoDelete;

		private bool _isStarted;

		protected bool _isFinished;

		protected float _totalTime;

		protected bool startExceptTime;

		private Action<ActionBase> _finishCallback;

		public int skillId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int skillIndexForDmode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool autoDelete => default(bool);

		public CharacterBase owner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CharacterBase creator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isStarted
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		public bool isFinished => default(bool);

		public float startTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isFromOption
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public RunActionParameterBase SyncRunActionParameter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual string GetProfilerDispString()
		{
			return null;
		}

		public void SetIsFromOption(bool isFromOption)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void Initialize(CharacterBase chara)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public virtual void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public virtual void Start()
		{
		}

		protected virtual void OnStart()
		{
		}

		protected virtual void OnFinish()
		{
		}

		public virtual bool Update(float delta)
		{
			return default(bool);
		}

		protected virtual bool IsMatchExecuteCondition()
		{
			return default(bool);
		}

		protected virtual bool IsCheckExecuteConditionEnabledOnStart()
		{
			return default(bool);
		}

		protected virtual bool ContinueCheckExecuteCondition(float t)
		{
			return default(bool);
		}

		public virtual bool IsConditionCheckResultFailed()
		{
			return default(bool);
		}

		public virtual void FixedUpdate(float delta)
		{
		}

		protected virtual bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected virtual bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		public void Finish()
		{
		}

		public virtual void Stop()
		{
		}

		public void SetActionFinished()
		{
		}

		public virtual void RemoveSelf()
		{
		}

		public virtual void SetCreator(CharacterBase creator)
		{
		}

		public virtual void SetSkillId(int id)
		{
		}

		public virtual void SetSkillIndexForDmode(int index)
		{
		}

		public void SetFinishCallback(Action<ActionBase> callback)
		{
		}

		public virtual void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public virtual void OnNotCollided(CharacterBase chara)
		{
		}

		public virtual void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
