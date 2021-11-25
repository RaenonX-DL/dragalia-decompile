using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.Cri
{
	public class FaderHolder : MonoBehaviour
	{
		public Dictionary<string, BusVolumeFader> BusVolumeFaderDict
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public List<CategoryAisacControlFader> CategoryAisacControlList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private void OnDestroy()
		{
		}

		private void KillAllBusVolumeFader()
		{
		}

		private void KillAllCategoryAisacControlFader()
		{
		}

		public void SetBusVolume(string busName, float toVolume, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetBusVolume(string busName, float fromVolume, float toVolume, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetCategoryAisacControl(string categoryName, string controlName, float toLevel, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetCategoryAisacControl(string categoryName, string controlName, float fromValue, float toLevel, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}
	}
}
