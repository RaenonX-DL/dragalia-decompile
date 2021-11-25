using UnityEngine;

namespace Gluon.Dungeon
{
	public class FieldScreenEffectTriggerShare : FieldScreenEffectTrigger
	{
		private static float shareEffectAlpha;

		protected static Coroutine shareProgressCoroutine;

		protected static FieldScreenEffectTrigger shareLastCoroutineStarter;

		protected override float effectAlpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override Coroutine progressCoroutine
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override FieldScreenEffectTrigger lastCoroutineStarter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
