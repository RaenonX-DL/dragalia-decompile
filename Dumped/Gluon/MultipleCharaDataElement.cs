using System;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;

namespace Gluon
{
	[Serializable]
	public class MultipleCharaDataElement
	{
		public Localize.TextId unitDetailNameTextId;

		public Localize.TextId characterTalkNameTextId;

		public int voiceBaseId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WeaponType weaponType
		{
			[CompilerGenerated]
			get
			{
				return default(WeaponType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int weaponSkinId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RenderPartsData.PartsNo modelPartsNo
		{
			[CompilerGenerated]
			get
			{
				return default(RenderPartsData.PartsNo);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MultipleCharaDataElement(int voiceBaseId, WeaponType weaponType, int weaponSkinId, RenderPartsData.PartsNo modelPartsNo, Localize.TextId unitDetailNameTextId, Localize.TextId characterTalkNameTextId)
		{
		}
	}
}
