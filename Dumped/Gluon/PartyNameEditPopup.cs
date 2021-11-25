namespace Gluon
{
	public class PartyNameEditPopup : NameEditPopupBase
	{
		private int partyIndex;

		public static PartyNameEditPopup Create()
		{
			return null;
		}

		public void InitPopup(int partyIndex)
		{
		}

		protected override string GetInputFieldDefaultText()
		{
			return null;
		}
	}
}
