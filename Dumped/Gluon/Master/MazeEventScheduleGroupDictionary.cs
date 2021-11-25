using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventScheduleGroupDictionary : SerializableDictionary<int, MazeEventSchedule>
	{
	}
}
