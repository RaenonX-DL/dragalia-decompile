namespace Gluon
{
	public class SummonOddsTableViewCell : TableViewCell<SummonOddsTableViewData>
	{
		public class OddsInfo
		{
			private int id;

			private string rate;

			private string displayName;
		}

		public SummonOddsPopupItemLine itemLine;

		public override void UpdateContent(SummonOddsTableViewData data)
		{
		}
	}
}
