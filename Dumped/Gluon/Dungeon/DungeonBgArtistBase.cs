using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistBase : FastUpdateMonoBehaviour
	{
		[SerializeField]
		private bool disableInIngameProduction;

		public const float cycleTimeScaleDefault = 1f;

		private static float cycleTimeScaleNow;

		protected virtual void Awake()
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
