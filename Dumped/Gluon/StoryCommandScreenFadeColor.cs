using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	[CommandName("fade_color")]
	public class StoryCommandScreenFadeColor : IStoryCommand
	{
		private IEnumerator coroutine;

		private Color color;

		private float sec;

		private Ease ease;

		private bool isCharacterFrontLayer;

		public void Start(float sec, int r, int g, int b, float a, int ease = 1, bool isCharacterFrontLayer = false)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		private IEnumerator _Update()
		{
			return null;
		}
	}
}
