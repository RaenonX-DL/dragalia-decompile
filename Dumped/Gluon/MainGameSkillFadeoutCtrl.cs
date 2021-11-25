using UnityEngine;

namespace Gluon
{
	public class MainGameSkillFadeoutCtrl
	{
		private enum State
		{
			None,
			FadeOut,
			Faded,
			FadeIn
		}

		private State state;

		private Color DEFAULT_COLOR;

		private float elapsedTime;

		private float duration;

		private Color currentColor;

		private Color startColor;

		private Color targetColor;

		private bool isAutoFadeIn;

		public void Clear()
		{
		}

		public void FadeOut(bool isAutoFadeIn = true)
		{
		}

		public void FadeIn()
		{
		}

		public void Update(float delta)
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsFadeOut()
		{
			return default(bool);
		}

		public void SetColorDefault()
		{
		}
	}
}
