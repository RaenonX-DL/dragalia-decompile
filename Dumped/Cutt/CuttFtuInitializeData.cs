using System;

namespace Cutt
{
	[Serializable]
	public class CuttFtuInitializeData
	{
		public enum ObjectType
		{
			Text,
			Texture
		}

		public enum Conditions
		{
			Fixed,
			Difficulty
		}

		public int characterIndex;

		public ObjectType type;

		public string targetObjectName;

		public Conditions conditions;

		public string[] dataString;

		public CuttFtuInitializeData(ObjectType type, string targetObjectName, Conditions conditions, string[] array)
		{
		}
	}
}
