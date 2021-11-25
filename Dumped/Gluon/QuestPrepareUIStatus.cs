using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestPrepareUIStatus : PartyUIStatus
	{
		public QuestPrepareScene questPrepareScene;

		public GameObject disabledImage;

		public PointerEventHandler eventHandler;

		public void SetSupportCharaData(int charaId, int charaLevel, int dragonId, int weaponId)
		{
		}

		public override void OnEquipChangeButtonPressed()
		{
		}

		public override void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int type3Crest1Id, int type3Crest2Id, int skill3CharaId = 0, int skill4CharaId = 0)
		{
		}

		public void OnShareSkillPopupReload()
		{
		}

		public new void EmptyFramePressed(int tag)
		{
		}

		public override void SyncAttributeMatchEffect([Optional] AutoPartyConfigData selectData)
		{
		}
	}
}
