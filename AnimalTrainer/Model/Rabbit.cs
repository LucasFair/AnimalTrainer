using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTrainer.Model
{
	internal class Rabbit
	{
		protected private bool _hasFur;
		protected private char _furLength;
		protected private string _earType;

		public bool HasFur
		{
			get { return _hasFur; }
			private set { _hasFur = value; }
		}
		public char FurLength
		{
			get { return _furLength; }
			private set { _furLength = value; }
		}
		public string EarType
		{
			get { return _earType; }
			private set { _earType = value; }
		}
		protected internal Rabbit()
		{
			_hasFur = true;
			_furLength = 'X';
			_earType = null;
		}
		protected internal Rabbit(string earType) : this()
		{
			_earType = earType;
		}
		protected internal Rabbit(bool hasFur, char furLength, string earType) : this(earType)
		{
			_hasFur = hasFur;
			_furLength = furLength;
		}
	}
}
