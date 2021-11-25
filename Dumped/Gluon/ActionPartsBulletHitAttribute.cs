using System.Runtime.CompilerServices;

namespace Gluon
{
	public class ActionPartsBulletHitAttribute
	{
		public CollisionHitAttribute hitAttr
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(InGameDef.CharacterType charaType, int actionid, string label)
		{
		}

		private void InitializeForPlayer(int actionid, string label)
		{
		}

		private void InitializeForEnemy(int actionid, string label)
		{
		}
	}
}
