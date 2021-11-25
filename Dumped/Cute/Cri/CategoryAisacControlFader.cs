using System;
using System.Runtime.CompilerServices;

namespace Cute.Cri
{
	public class CategoryAisacControlFader : IDisposable
	{
		private FaderCore fader;

		public FadeStatus Status => default(FadeStatus);

		public string CategoryName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string ControlName
		{
			[CompilerGenerated]
			get
			{
				return null;
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

		public CategoryAisacControlFader(string categoryName, string controlName)
		{
		}

		public void Dispose()
		{
		}

		public void Kill()
		{
		}

		public bool IsSameFader(string categoryName, string controlName)
		{
			return default(bool);
		}

		private float GetControlValue()
		{
			return default(float);
		}

		private void SetControlValue(float controlValue)
		{
		}

		public void FadeValue(float toValue, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void FadeValue(float fromValue, float toValue, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}
	}
}
