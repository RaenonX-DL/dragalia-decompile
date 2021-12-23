using UnityEngine;

namespace Gluon
{
	public class InGameUICharaResourceData : InGameUICommonResourceData
	{
		public Material humanFaceMaterial;

		public Material humanFaceMonoMaterial;

		public Sprite humanFaceSprite;

		public Sprite humanFaceMonoSprite;

		public Material humanBustupMaterial;

		public Material humanBustupDamageMaterial;

		public Material humanDmodeStrategyMatarial;

		public Material uniqueTransButtonMaterial;

		~InGameUICharaResourceData()
		{
		}

		public override void Destroy()
		{
		}
	}
}
