using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;

namespace Cute.Cri
{
	public class FaderCore : IUpdatable, IDisposable
	{
		public delegate float FadeCurveFunc(float startValue, float endValue, float t);

		private const double ExponentialBase = 2.0;

		private const double ExponentialCoefficient = 10.0;

		private float fromValue;

		private float toValue;

		private float fadeTime;

		private Func<float> valueGetter;

		private Action<float> valueSetter;

		private Action startCallback;

		private Action endCallback;

		private bool isFadeOut;

		private float lastRealTime;

		private float elapsedTime;

		private FadeCurveFunc fadeCurveFunc;

		private bool isAddedToUpdateDispatcher;

		public FadeStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(FadeStatus);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Pause
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float ElapsedValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static float GetCubic(float x)
		{
			return default(float);
		}

		private static float GetExpo(float x)
		{
			return default(float);
		}

		private void AddToUpdateDispatcher()
		{
		}

		private void RemoveFromUpdateDispatcher()
		{
		}

		public void Dispose()
		{
		}

		public void Do(float fromValue, float toValue, float fadeTime, Func<float> valueGetter, Action<float> valueSetter, [Optional] Action startCallback, [Optional] Action endCallback, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public static FadeCurveFunc GetFadeCurveFunc(FadeCurve fadeCurve)
		{
			return null;
		}

		public void FastUpdate()
		{
		}

		public void Complete()
		{
		}

		public void Kill()
		{
		}
	}
}
