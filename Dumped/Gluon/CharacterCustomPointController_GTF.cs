using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_GTF : CharacterCustomPointController
	{
		private float fCp;

		private const int EnhanceSkill1BuffId = 2021;

		private const int EnhanceSkill2BuffId = 2023;

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void Update()
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index, int prevCP, int currCP)
		{
		}

		private void OnCPMatched(AbilityDataElement ade, int skillId, int skillIndex)
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}

		public override bool ClearCPOnContinue()
		{
			return default(bool);
		}

		public override void OnReceiveCharacterCustomPointEvent(CharacterCustomPointEvent recvEvent)
		{
		}

		private void SetToAxeMode(PlayerCharacter player, bool fromRecvEvent)
		{
		}
	}
}
