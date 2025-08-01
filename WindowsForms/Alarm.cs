using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
	public enum AlarmsTypes
	{
		Time,
		DateTime
	}


	internal class Alarm
	{
		public string time { get; set; }
		public string date { get; set; }
		public AlarmsTypes type { get; set; }


		public Alarm() { }
		public Alarm(string time_, string date_, AlarmsTypes type_)
		{
			this.time = time_;
			this.date = date_;
			this.type = type_;
		}
		public Alarm (string content)
		{
			this.time = content.Split(';')[0];
			this.date = content.Split(';')[1];
			this.type = (AlarmsTypes)Enum.Parse(typeof(AlarmsTypes), content.Split(';')[2]);
		}

		public override string ToString()
		{
			return $"{this.time};{this.date};{this.type.ToString()}";
		}



	}
}
