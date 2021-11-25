namespace Cutt
{
	public interface ICuttTimelineGroupDataWithName
	{
		ICuttTimelineKeyDataList GetKeyList();

		int GetNameHash();

		void MakeNameHash();
	}
}
