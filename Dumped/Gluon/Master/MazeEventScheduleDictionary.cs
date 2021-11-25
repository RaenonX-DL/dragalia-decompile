using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventScheduleDictionary : SerializableDictionary<int, MazeEventScheduleElement>
	{
	}
}
