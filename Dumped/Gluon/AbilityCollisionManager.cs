using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class AbilityCollisionManager
	{
		private List<CollisionHitAttribute> newAttributes;

		private List<CollisionHitAttribute> attributes;

		public bool Regist(CharacterBase owner, string label, int actionId = 0, int skillId = 0, int bulletId = 0, int productId = 0, [Optional] CollisionHitAttribute originHitAttribute, bool isLink = false)
		{
			return default(bool);
		}

		public bool RegistRandomHit(CharacterBase damagedChara, CollisionHitAttribute orgAttr)
		{
			return default(bool);
		}

		public void Update()
		{
		}
	}
}
