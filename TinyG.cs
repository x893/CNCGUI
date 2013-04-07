using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CNCGUI
{
	public class TinyG
	{
		private Version fb = new Version();
		public Version FirmwareBuild { get { return fb; } }

		private Version fv = new Version();
		public Version FirmwareVersion { get { return fv; } }

		private Version hv = new Version();
		public Version HardwareVersion { get { return hv; } }

		public string ID { get; set; }

		private IntegerUnit ja = new IntegerUnit();
		public IntegerUnit JunctionAcceleration { get { return ja; } }

		private FloatUnit ct = new FloatUnit();
		public FloatUnit ChordalTolerance { get { return ct; } }

		private EnumValue st = new EnumValue(typeof(SWITCH_TYPE));
		public EnumValue SwitchType { get { return st; } }

		private EnumValue ej = new EnumValue(typeof(JSON_MODE));
		public EnumValue JsonMode { get { return ej; } }

		private EnumValue jv = new EnumValue(typeof(JSON_VERBOSITY));
		public EnumValue JsonVerbosity { get { return jv; } }

		private EnumValue tv = new EnumValue(typeof(TEXT_VERBOSITY));
		public EnumValue TextVerbosity { get { return tv; } }

		private EnumValue qv = new EnumValue(typeof(REPORT_VERBOSITY));
		public EnumValue QueueReportVerbosity { get { return qv; } }

		private EnumValue sv = new EnumValue(typeof(REPORT_VERBOSITY));
		public EnumValue StatusReportVerbosity { get { return sv; } }
		
		private EnumValue ic = new EnumValue(typeof(IGNORE_CRLF));
		public EnumValue IgnoreCRLF { get { return ic; } }
		
		private EnumValue ec = new EnumValue(typeof(ON_OFF));
		public EnumValue ExpandLF { get { return ec; } }
		
		private EnumValue ee = new EnumValue(typeof(ON_OFF));
		public EnumValue EnableEcho { get { return ee; } }
		
		private EnumValue ex = new EnumValue(typeof(ON_OFF));
		public EnumValue EnableXON { get { return ex; } }
		
		private EnumValue gpl = new EnumValue(typeof(GCODE_PLANE));
		public EnumValue DefaultGcodePlane { get { return gpl; } }
		
		private EnumValue gun = new EnumValue(typeof(GCODE_UNIT));
		public EnumValue DefaultGcodeUnits { get { return gun; } }
		
		private EnumValue gco = new EnumValue(typeof(GCODE_COORD));
		public EnumValue DefaultGcodeCoord { get { return gco; } }
		
		private EnumValue gpa = new EnumValue(typeof(GCODE_PATH));
		public EnumValue DefaultGcodePath { get { return gpa; } }
		
		private EnumValue gdi = new EnumValue(typeof(GCODE_DISTANCE));
		public EnumValue DefaultGcodeDistance { get { return gdi; } }
		
		private EnumValue baud = new EnumValue(typeof(USB_BAUDRATE));
		public EnumValue UsbBaudRate { get { return baud; } }

		public int StatusInterval = 100;
		public Motor[] Motors = new Motor[4];
		public Axis[] Axises = new Axis[6];

		public TinyG()
		{
			for (int i = 0; i < Motors.Length; i++)
				Motors[i] = new Motor();
			for (int i = 0; i < Axises.Length; i++)
				Axises[i] = new Axis();
		}
	}

	public class Motor
	{
		private EnumValue ma = new EnumValue(typeof(MOTOR_AXIS));
		public EnumValue Axis { get { return ma; } }

		private EnumValue pm = new EnumValue(typeof(ON_OFF));
		public EnumValue PowerManagement { get { return pm; } }

		private EnumValue po = new EnumValue(typeof(MOTOR_POLARITY));
		public EnumValue Polarity { get { return po; } }

		private EnumValue mi = new EnumValue(typeof(MOTOR_STEP));
		public EnumValue Microstep { get { return mi; } }

		private FloatUnit tr = new FloatUnit();
		public FloatUnit TravelPerRevolution { get { return tr; } }

		public float StepAngle;
	}

	public class Axis
	{
		private EnumValue am = new EnumValue(typeof(AXIS_MODE));
		public EnumValue AxisMode { get { return am; } }

		private EnumValue sn = new EnumValue(typeof(AXIS_SWITCH));
		public EnumValue SwitchMin { get { return sn; } }

		private EnumValue sm = new EnumValue(typeof(AXIS_SWITCH));
		public EnumValue SwitchMax { get { return sm; } }

		public float Velocity;
		public float Feedrate;
		public int JerkHoming;
		public float JunctionDeviation;
		public float SearchVelocity;
		public float LatchVelocity;
		public float LatchBackoff;
		public float ZeroBackoff;
		public float TravelMaximum;
		public int JerkMaximum;
		public float Radius;
	}

	public enum MOTOR_STEP
	{
		Step_1 = 1,
		Step_2 = 2,
		Step_4 = 4,
		Step_8 = 8
	}
	public enum MOTOR_POLARITY
	{
		Normal = 0,
		Reverse = 1
	}
	public enum MOTOR_AXIS
	{
		X=0,
		Y=1,
		Z=2,
		A=3
	}
	public enum AXIS_SWITCH
	{
		Off = 0,
		Homing = 1,
		Limit = 2,
		LimitHoming = 3
	}
	public enum AXIS_MODE
	{
		Disabled = 0,
		Standard = 1
	}
	public enum USB_BAUDRATE
	{
		Speed_9600 = 1,
		Speed_19200 = 2,
		Speed_38400 = 3,
		Speed_57600 = 4,
		Speed_115200 = 5,
		Speed_230400 = 6
	}
	public enum GCODE_DISTANCE
	{
		G90 = 0,
		G91 = 1
	}
	public enum GCODE_PATH
	{
		G61 = 0,
		G61_1 = 1,
		G64 = 2
	}
	public enum GCODE_COORD
	{
		G54 = 1,
		G55 = 2,
		G56 = 3,
		G57 = 4,
		G58 = 5,
		G59 = 6
	}
	public enum GCODE_UNIT
	{
		G20 = 0,
		G21 = 1
	}
	public enum GCODE_PLANE
	{
		G17 = 0,
		G18 = 1,
		G19 = 2
	}
	public enum IGNORE_CRLF
	{
		Off = 0,
		CR = 1,
		LF = 2
	}
	public enum ON_OFF
	{
		Off = 0,
		On = 1
	}
	public enum SWITCH_TYPE
	{
		NormalOpen = 0,
		NormalClose = 1
	}

	public enum JSON_MODE
	{
		Text = 0,
		Json = 1
	}
	public enum JSON_VERBOSITY
	{
		Silent = 0,
		Footer = 1,
		Messages = 2,
		Configs = 3,
		Linenum = 4,
		Verbose = 5
	}
	public enum TEXT_VERBOSITY
	{
		Silent = 0,
		Verbose = 1
	}
	public enum REPORT_VERBOSITY
	{
		Off = 0,
		Filtered = 1,
		Verbose = 2
	}
	public enum UNIT
	{
		mm = 0,
		inch = 1
	}

	public class EnumValue
	{
		public Dictionary<int,string> Items;
		public Type EnumType;
		public int m_value_int;
		public Enum m_value;

		public EnumValue()
		{
		}
		public override string ToString()
		{
			return string.Concat("enum:", EnumType.ToString());
		}

		public EnumValue(Type enumType)
		{
			EnumType = enumType;
		}

		public Enum Value
		{
			get { return m_value; }
			set
			{
				m_value = value;
				m_value_int = (int)Convert.ChangeType(value, EnumType);
			}
		}
		public int ValueInt
		{
			get { return m_value_int; }
			set
			{
				m_value_int = value;
				m_value = (Enum)Enum.ToObject(EnumType, m_value_int);
			}
		}

		public void Set(ScanFormatted scanf, bool use_items)
		{
			if (use_items)
			{
				Set(scanf);
			}
			else if (scanf.Results.Count >= 1)
			{
				Items = null;
				Set(scanf.Results[0]);
			}
		}

		public void Set(object value)
		{
			if (value is int)
				ValueInt = (int)value;
		}

		public void Set(ScanFormatted scanf)
		{
			if (scanf.Results.Count >= 1)
				Set(scanf.Results[0]);

			if (scanf.Results.Count >= 2)
			{
				if (Items == null)
					Items = new Dictionary<int, string>();
				else
					Items.Clear();

				foreach (string item in ((string)scanf.Results[1]).Split(Common.CHAR_COMMA))
				{
					string pair = item.Trim();
					int value = -1; string key = string.Empty;
					int idx;
					if (!string.IsNullOrEmpty(pair))
					{
						if ((idx = pair.IndexOf('=')) >= 0)
						{
							if (idx > 0)
							{
								if (!int.TryParse(pair.Substring(0, idx), NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
									continue;
							}
							if (idx + 1 >= pair.Length)
								continue;
							key = pair.Substring(idx + 1);
							if (key.Length > 1)
							{
								if (key.EndsWith("]"))
									key = key.Substring(0, key.Length - 1);
								if (!Items.ContainsKey(value))
									Items.Add(value, key);
							}
						}
						else
						{
							if (pair.EndsWith("]"))
								pair = pair.Substring(0, pair.Length - 1);
							if (!int.TryParse(pair, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
								continue;
							if (!Items.ContainsKey(value))
								Items.Add(value, pair);
						}
					}
				}
			}
		}
	}

	public class IntegerUnit
	{
		public UNIT Unit { get; set; }
		public int Value { get; set; }

		public IntegerUnit()
		{
			Unit = UNIT.mm;
			Value = 0;
		}

		internal void Set(ScanFormatted scanf)
		{
			Default();
			if (scanf.Results.Count >= 1)
				Value = (int)scanf.Results[0];
			if (scanf.Results.Count >= 2)
			{
				string unit = (string)scanf.Results[1];
				if (!string.IsNullOrEmpty(unit) && unit.ToLower() == "in")
					Unit = UNIT.inch;
			}
		}
		internal void Default()
		{
			Unit = UNIT.mm;
			Value = 0;
		}
	}

	public class FloatUnit
	{
		public UNIT Unit { get; set; }
		public float Value { get; set; }

		internal void Set(ScanFormatted scanf)
		{
			Default();
			if (scanf.Results.Count >= 1)
				Value = (float)scanf.Results[0];
			if (scanf.Results.Count >= 2)
			{
				string unit = (string)scanf.Results[1];
				if (!string.IsNullOrEmpty(unit) && unit.ToLower() == "in")
					Unit = UNIT.inch;
			}
		}
		internal void Default()
		{
			Unit = UNIT.mm;
			Value = 0;
		}
	}

	public class Version
	{
		public int Major { get; set; }
		public int Minor { get; set; }
		public override string ToString()
		{
			return string.Format("{0}.{1}", Major, Minor);
		}

		internal void Clear()
		{
			Major = 0;
			Minor = 0;
		}
	}
}