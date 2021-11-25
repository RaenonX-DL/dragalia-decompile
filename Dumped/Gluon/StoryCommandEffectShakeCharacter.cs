using System.Collections;

namespace Gluon
{
	[CommandName("effect_shake_chara")]
	public class StoryCommandEffectShakeCharacter : IStoryCommand
	{
		private IEnumerator coroutine;

		private int type;

		private float peekSec;

		private float stopSec;

		private int ease;

		private bool isWithBg;

		public void Start(int type, float peekSec = 3f, float stopSec = 3f, int ease = 1)
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
