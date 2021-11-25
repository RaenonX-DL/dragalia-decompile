using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class CuttDriverInGame : CuttDriver
	{
		protected float cuttTime;

		private bool resetPauseFlag;

		private bool skipAllFlag;

		private bool skipOnceFlag;

		protected string cuttDataName;

		protected GameObject cuttData;

		protected bool _isInitialized;

		protected bool _isIngameCutt;

		private bool stopUpdateFlag;

		public bool isInitialized
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		public void SetIngameCutt()
		{
		}

		public void StopUpdate(bool flag)
		{
		}

		protected override void Awake()
		{
		}

		public override IEnumerator Start()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		public override void Update()
		{
		}

		protected void UpdateInGame()
		{
		}

		public void ResetPause()
		{
		}

		public void SkipAll()
		{
		}

		public bool IsLast()
		{
			return default(bool);
		}

		public bool IsPausing()
		{
			return default(bool);
		}

		private float GetPauseTime()
		{
			return default(float);
		}

		public float GetWaitEventTime()
		{
			return default(float);
		}

		public bool GetTapWait()
		{
			return default(bool);
		}

		public void ResetWaitEvent()
		{
		}

		public float GetNextCuttEventTime()
		{
			return default(float);
		}

		public void SetLoadDataName(string name)
		{
		}

		public void ResetPlayTime(bool start, int jumpId = 0)
		{
		}
	}
}
