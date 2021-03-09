using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Container(Layout.Stack)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stTreeStruct", "Plc", TypeComplexityEnum.Complex)]
	public partial class stTreeStruct : Vortex.Connector.IVortexObject, IstTreeStruct, IShadowstTreeStruct, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerBool _One;
		public Vortex.Connector.ValueTypes.OnlinerBool One
		{
			get
			{
				return _One;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstTreeStruct.One
		{
			get
			{
				return One;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstTreeStruct.One
		{
			get
			{
				return One;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Two;
		public Vortex.Connector.ValueTypes.OnlinerBool Two
		{
			get
			{
				return _Two;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstTreeStruct.Two
		{
			get
			{
				return Two;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstTreeStruct.Two
		{
			get
			{
				return Two;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Another;
		public Vortex.Connector.ValueTypes.OnlinerString Another
		{
			get
			{
				return _Another;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstTreeStruct.Another
		{
			get
			{
				return Another;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstTreeStruct.Another
		{
			get
			{
				return Another;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _ThisOne;
		public Vortex.Connector.ValueTypes.OnlinerString ThisOne
		{
			get
			{
				return _ThisOne;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstTreeStruct.ThisOne
		{
			get
			{
				return ThisOne;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstTreeStruct.ThisOne
		{
			get
			{
				return ThisOne;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ANumberWouldBeCool;
		public Vortex.Connector.ValueTypes.OnlinerInt ANumberWouldBeCool
		{
			get
			{
				return _ANumberWouldBeCool;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IstTreeStruct.ANumberWouldBeCool
		{
			get
			{
				return ANumberWouldBeCool;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstTreeStruct.ANumberWouldBeCool
		{
			get
			{
				return ANumberWouldBeCool;
			}
		}

		stBools _Bools;
		public stBools Bools
		{
			get
			{
				return _Bools;
			}
		}

		IstBools IstTreeStruct.Bools
		{
			get
			{
				return Bools;
			}
		}

		IShadowstBools IShadowstTreeStruct.Bools
		{
			get
			{
				return Bools;
			}
		}

		public void LazyOnlineToShadow()
		{
			One.Shadow = One.LastValue;
			Two.Shadow = Two.LastValue;
			Another.Shadow = Another.LastValue;
			ThisOne.Shadow = ThisOne.LastValue;
			ANumberWouldBeCool.Shadow = ANumberWouldBeCool.LastValue;
			Bools.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			One.Cyclic = One.Shadow;
			Two.Cyclic = Two.Shadow;
			Another.Cyclic = Another.Shadow;
			ThisOne.Cyclic = ThisOne.Shadow;
			ANumberWouldBeCool.Cyclic = ANumberWouldBeCool.Shadow;
			Bools.LazyShadowToOnline();
		}

		public PlainstTreeStruct CreatePlainerType()
		{
			var cloned = new PlainstTreeStruct();
			cloned.Bools = Bools.CreatePlainerType();
			return cloned;
		}

		protected PlainstTreeStruct CreatePlainerType(PlainstTreeStruct cloned)
		{
			cloned.Bools = Bools.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainstTreeStruct source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstTreeStruct source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainstTreeStruct source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public stTreeStruct(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_One = @Connector.Online.Adapter.CreateBOOL(this, "", "One");
			_Two = @Connector.Online.Adapter.CreateBOOL(this, "", "Two");
			_Another = @Connector.Online.Adapter.CreateSTRING(this, "", "Another");
			_ThisOne = @Connector.Online.Adapter.CreateSTRING(this, "", "ThisOne");
			_ANumberWouldBeCool = @Connector.Online.Adapter.CreateINT(this, "", "ANumberWouldBeCool");
			_Bools = new stBools(this, "", "Bools");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public stTreeStruct()
		{
			PexPreConstructorParameterless();
			_One = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_Two = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_Another = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_ThisOne = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_ANumberWouldBeCool = Vortex.Connector.IConnectorFactory.CreateINT();
			_Bools = new stBools();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstTreeStruct
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstTreeStruct()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstTreeStruct : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool One
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Two
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString Another
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString ThisOne
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ANumberWouldBeCool
		{
			get;
		}

		IstBools Bools
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstTreeStruct CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstTreeStruct source);
		void FlushOnlineToPlain(Plc.PlainstTreeStruct source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstTreeStruct : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool One
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Two
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString Another
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString ThisOne
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ANumberWouldBeCool
		{
			get;
		}

		IShadowstBools Bools
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstTreeStruct CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstTreeStruct source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstTreeStruct : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _One;
		public System.Boolean One
		{
			get
			{
				return _One;
			}

			set
			{
				if (_One != value)
				{
					_One = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(One)));
				}
			}
		}

		System.Boolean _Two;
		public System.Boolean Two
		{
			get
			{
				return _Two;
			}

			set
			{
				if (_Two != value)
				{
					_Two = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Two)));
				}
			}
		}

		System.String _Another;
		public System.String Another
		{
			get
			{
				return _Another;
			}

			set
			{
				if (_Another != value)
				{
					_Another = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Another)));
				}
			}
		}

		System.String _ThisOne;
		public System.String ThisOne
		{
			get
			{
				return _ThisOne;
			}

			set
			{
				if (_ThisOne != value)
				{
					_ThisOne = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ThisOne)));
				}
			}
		}

		System.Int16 _ANumberWouldBeCool;
		public System.Int16 ANumberWouldBeCool
		{
			get
			{
				return _ANumberWouldBeCool;
			}

			set
			{
				if (_ANumberWouldBeCool != value)
				{
					_ANumberWouldBeCool = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ANumberWouldBeCool)));
				}
			}
		}

		PlainstBools _Bools;
		public PlainstBools Bools
		{
			get
			{
				return _Bools;
			}

			set
			{
				if (_Bools != value)
				{
					_Bools = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Bools)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stTreeStruct target)
		{
			target.One.Cyclic = One;
			target.Two.Cyclic = Two;
			target.Another.Cyclic = Another;
			target.ThisOne.Cyclic = ThisOne;
			target.ANumberWouldBeCool.Cyclic = ANumberWouldBeCool;
			Bools.CopyPlainToCyclic(target.Bools);
		}

		public void CopyPlainToCyclic(Plc.IstTreeStruct target)
		{
			this.CopyPlainToCyclic((Plc.stTreeStruct)target);
		}

		public void CopyPlainToShadow(Plc.stTreeStruct target)
		{
			target.One.Shadow = One;
			target.Two.Shadow = Two;
			target.Another.Shadow = Another;
			target.ThisOne.Shadow = ThisOne;
			target.ANumberWouldBeCool.Shadow = ANumberWouldBeCool;
			Bools.CopyPlainToShadow(target.Bools);
		}

		public void CopyPlainToShadow(Plc.IShadowstTreeStruct target)
		{
			this.CopyPlainToShadow((Plc.stTreeStruct)target);
		}

		public void CopyCyclicToPlain(Plc.stTreeStruct source)
		{
			One = source.One.LastValue;
			Two = source.Two.LastValue;
			Another = source.Another.LastValue;
			ThisOne = source.ThisOne.LastValue;
			ANumberWouldBeCool = source.ANumberWouldBeCool.LastValue;
			Bools.CopyCyclicToPlain(source.Bools);
		}

		public void CopyCyclicToPlain(Plc.IstTreeStruct source)
		{
			this.CopyCyclicToPlain((Plc.stTreeStruct)source);
		}

		public void CopyShadowToPlain(Plc.stTreeStruct source)
		{
			One = source.One.Shadow;
			Two = source.Two.Shadow;
			Another = source.Another.Shadow;
			ThisOne = source.ThisOne.Shadow;
			ANumberWouldBeCool = source.ANumberWouldBeCool.Shadow;
			Bools.CopyShadowToPlain(source.Bools);
		}

		public void CopyShadowToPlain(Plc.IShadowstTreeStruct source)
		{
			this.CopyShadowToPlain((Plc.stTreeStruct)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstTreeStruct()
		{
			_Bools = new PlainstBools();
		}
	}
}