using System.Runtime.CompilerServices;

namespace Gluon.Shooting
{
	public class PlayerBullet : BaseObject
	{
		public enum Phase
		{
			Normal,
			FadeOut
		}

		private int level;

		private float xplus;

		private float yplus;

		private float r;

		private PlayerBulletTemplate template;

		private const int fadeOutTime = 32;

		private Phase phase;

		public float power
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

		public bool able
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Action()
		{
		}

		private void UpdateFrame()
		{
		}

		public void HitOn()
		{
		}

		public bool IsInRange(float aimx, float aimy, float w, float h)
		{
			return default(bool);
		}

		public void SetSortingOrder(int z)
		{
		}

		public bool ValueSet(int index, float xOffset, float yOffset, int angle, float speed, float power, PlayerBulletTemplate _template, int delayIndex)
		{
			return default(bool);
		}
	}
}
