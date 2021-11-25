namespace Gluon
{
	public class PartyEquipSetNameEditPopup : NameEditPopupBase
	{
		private int charaId;

		private int setIndex;

		public static PartyEquipSetNameEditPopup Create()
		{
			return null;
		}

		public void InitPopup(int charaId, int setIndex)
		{
		}

		protected override string GetInputFieldDefaultText()
		{
			return null;
		}
	}
}
