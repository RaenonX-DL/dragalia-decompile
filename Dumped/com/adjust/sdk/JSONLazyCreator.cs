namespace com.adjust.sdk
{
	internal class JSONLazyCreator : JSONNode
	{
		private JSONNode m_Node;

		private string m_Key;

		public override JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int AsInt
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public override float AsFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override double AsDouble
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override JSONArray AsArray => null;

		public override JSONClass AsObject => null;

		public JSONLazyCreator(JSONNode aNode)
		{
		}

		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		private void Set(JSONNode aVal)
		{
		}

		public override void Add(JSONNode aItem)
		{
		}

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}
