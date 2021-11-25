using System.Collections;
using UnityEngine;

namespace Gluon
{
	[CommandName("multi_scroll")]
	public class StoryCommandBackgrundMultiScroll : IStoryCommand
	{
		private IEnumerator coroutine;

		private float sec;

		private Color color;

		private Vector3 endPos;

		public void Start(float sec, float endPosX, float endPosY, int[] rgb)
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
