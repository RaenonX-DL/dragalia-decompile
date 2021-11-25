using System.Collections.Generic;

namespace Gluon
{
	public class GrowthCharaTalkSelector : OutGameTopCharaTalkSelector
	{
		public GrowthScene.CharaType charaType;

		public static Queue<int> myLastPlayedQueue;

		public static void ClearLastPlayedQueue()
		{
		}

		public void Init(GrowthScene.CharaType charaType)
		{
		}
	}
}
