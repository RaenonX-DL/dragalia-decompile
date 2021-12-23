using UnityEngine;

namespace Gluon
{
	public class InGameUIDragonResourceData : InGameUICommonResourceData
	{
		public Material dragonFaceMaterial;

		public Material dragonFaceMonoMaterial;

		public Sprite dragonFaceSprite;

		public Sprite dragonFaceMonoSprite;

		public Material dragonBustupMaterial;

		public Material dragonDmodeStrategyMatarial;

		public Material dragonButtonMaterial;

		~InGameUIDragonResourceData()
		{
		}

		public override void Destroy()
		{
		}
	}
}
