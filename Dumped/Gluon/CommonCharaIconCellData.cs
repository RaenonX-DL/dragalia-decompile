namespace Gluon
{
	public class CommonCharaIconCellData : CommonIconListCellData
	{
		public enum DisableType
		{
			None,
			DmodeSuspendedCharacter
		}

		public bool isParty;

		public DisableType disableType;
	}
}
