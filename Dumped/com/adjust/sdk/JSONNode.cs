using System.Collections.Generic;
using System.IO;

namespace com.adjust.sdk
{
	public class JSONNode
	{
		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int Count => default(int);

		public virtual IEnumerable<JSONNode> Childs => null;

		public IEnumerable<JSONNode> DeepChilds => null;

		public virtual int AsInt
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public virtual double AsDouble
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public virtual bool AsBool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual JSONArray AsArray => null;

		public virtual JSONClass AsObject => null;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		public static bool operator !=(JSONNode a, object b)
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

		internal static string Escape(string aText)
		{
			return null;
		}

		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		public void SaveToStream(Stream aData)
		{
		}

		public void SaveToCompressedStream(Stream aData)
		{
		}

		public void SaveToCompressedFile(string aFileName)
		{
		}

		public string SaveToCompressedBase64()
		{
			return null;
		}

		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}
	}
}
