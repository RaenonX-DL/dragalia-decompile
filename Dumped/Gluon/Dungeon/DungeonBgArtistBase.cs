using System.Collections;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistBase : FastUpdateMonoBehaviour
	{
		public enum LoopType
		{
			Loop,
			Once,
			OnceAndDisable
		}

		[SerializeField]
		private bool disableInIngameProduction;

		[SerializeField]
		protected DungeonBgArtistCollider targetCollider;

		[SerializeField]
		protected LoopType loopType;

		public const float cycleTimeScaleDefault = 1f;

		private static float cycleTimeScaleNow;

		public LoopType GetLoopType()
		{
			return default(LoopType);
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void PlayCurve()
		{
		}

		protected IEnumerator CoColliderWait()
		{
			return null;
		}

		protected bool IsLoop(float now, float once)
		{
			return default(bool);
		}

		protected virtual void Finish()
		{
		}

		protected bool IsPauseUpdate()
		{
			return default(bool);
		}

		public static void SetCycleTimeScale(float scale)
		{
		}

		protected float GetDeltaTime()
		{
			return default(float);
		}

		protected float GetCurrentCurveValue(AnimationCurve curve, float cycleNow, float cycleMax)
		{
			return default(float);
		}
	}
}
