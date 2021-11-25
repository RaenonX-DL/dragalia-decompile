namespace FLATOUT.Main.Utility
{
	public abstract class FlBlendBase
	{
		public enum BlendTypes
		{
			Linear,
			Up,
			Down,
			UpDown,
			Up2,
			Down2,
			UpDown2
		}

		protected BlendTypes _blendType;

		protected float _currentBlendTime;

		protected float _blendTime;

		protected float _currentBlendValue;

		protected float _currentFixBlendValue;

		protected bool _pause;

		public BlendTypes BlendType => default(BlendTypes);

		public float CurrentBlendTime => default(float);

		public float BlendTime => default(float);

		public float CurrentBlendValue => default(float);

		public float CurrentFixBlendValue => default(float);

		public bool Pause => default(bool);

		public virtual void Reset()
		{
		}

		public virtual void Update(float deltaTime)
		{
		}

		public virtual void SetBlendType(BlendTypes blendType)
		{
		}

		public virtual void SetBlendTime(float blendTime)
		{
		}

		public virtual void SetCurrentBlendTime(float currentBlendTime)
		{
		}

		public virtual void SetPause(bool pause)
		{
		}
	}
}
