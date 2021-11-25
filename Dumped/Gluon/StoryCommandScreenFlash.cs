using System.Collections;
using UnityEngine;

namespace Gluon
{
	[CommandName("screen_flash")]
	public class StoryCommandScreenFlash : IStoryCommand
	{
		private IEnumerator coroutine;

		private Color color;

		private float sec;

		public void Start(float sec, int[] rgb)
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
