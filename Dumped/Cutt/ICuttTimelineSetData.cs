namespace Cutt
{
	public interface ICuttTimelineSetData
	{
		ICuttTimelineKeyDataList GetKeyList(int index);

		ICuttTimelineKeyDataList[] GetKeyListArray();

		CuttTimelineKeyDataType[] GetKeyTypeArray();
	}
}
