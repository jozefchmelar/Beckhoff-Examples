using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Container(Layout.Stack)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stBools", "Plc", TypeComplexityEnum.Complex)]
	public partial class stBools : Vortex.Connector.IVortexObject, IstBools, IShadowstBools, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _BoolOne;
		public Vortex.Connector.ValueTypes.OnlinerBool BoolOne
		{
			get
			{
				return _BoolOne;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstBools.BoolOne
		{
			get
			{
				return BoolOne;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstBools.BoolOne
		{
			get
			{
				return BoolOne;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _BoolTwo;
		public Vortex.Connector.ValueTypes.OnlinerBool BoolTwo
		{
			get
			{
				return _BoolTwo;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstBools.BoolTwo
		{
			get
			{
				return BoolTwo;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstBools.BoolTwo
		{
			get
			{
				return BoolTwo;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _BoolThree;
		public Vortex.Connector.ValueTypes.OnlinerBool BoolThree
		{
			get
			{
				return _BoolThree;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstBools.BoolThree
		{
			get
			{
				return BoolThree;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstBools.BoolThree
		{
			get
			{
				return BoolThree;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _BoolFive;
		public Vortex.Connector.ValueTypes.OnlinerBool BoolFive
		{
			get
			{
				return _BoolFive;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstBools.BoolFive
		{
			get
			{
				return BoolFive;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstBools.BoolFive
		{
			get
			{
				return BoolFive;
			}
		}

		public void LazyOnlineToShadow()
		{
			BoolOne.Shadow = BoolOne.LastValue;
			BoolTwo.Shadow = BoolTwo.LastValue;
			BoolThree.Shadow = BoolThree.LastValue;
			BoolFive.Shadow = BoolFive.LastValue;
		}

		public void LazyShadowToOnline()
		{
			BoolOne.Cyclic = BoolOne.Shadow;
			BoolTwo.Cyclic = BoolTwo.Shadow;
			BoolThree.Cyclic = BoolThree.Shadow;
			BoolFive.Cyclic = BoolFive.Shadow;
		}

		public PlainstBools CreatePlainerType()
		{
			var cloned = new PlainstBools();
			return cloned;
		}

		protected PlainstBools CreatePlainerType(PlainstBools cloned)
		{
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

		public void FlushPlainToOnline(Plc.PlainstBools source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstBools source)
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

		public void FlushOnlineToPlain(Plc.PlainstBools source)
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

		public stBools(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_BoolOne = @Connector.Online.Adapter.CreateBOOL(this, "", "BoolOne");
			_BoolTwo = @Connector.Online.Adapter.CreateBOOL(this, "", "BoolTwo");
			_BoolThree = @Connector.Online.Adapter.CreateBOOL(this, "", "BoolThree");
			_BoolFive = @Connector.Online.Adapter.CreateBOOL(this, "", "BoolFive");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public stBools()
		{
			PexPreConstructorParameterless();
			_BoolOne = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_BoolTwo = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_BoolThree = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_BoolFive = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstBools
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstBools()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstBools : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool BoolOne
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool BoolTwo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool BoolThree
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool BoolFive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstBools CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstBools source);
		void FlushOnlineToPlain(Plc.PlainstBools source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstBools : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool BoolOne
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool BoolTwo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool BoolThree
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool BoolFive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstBools CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstBools source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstBools : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _BoolOne;
		public System.Boolean BoolOne
		{
			get
			{
				return _BoolOne;
			}

			set
			{
				if (_BoolOne != value)
				{
					_BoolOne = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BoolOne)));
				}
			}
		}

		System.Boolean _BoolTwo;
		public System.Boolean BoolTwo
		{
			get
			{
				return _BoolTwo;
			}

			set
			{
				if (_BoolTwo != value)
				{
					_BoolTwo = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BoolTwo)));
				}
			}
		}

		System.Boolean _BoolThree;
		public System.Boolean BoolThree
		{
			get
			{
				return _BoolThree;
			}

			set
			{
				if (_BoolThree != value)
				{
					_BoolThree = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BoolThree)));
				}
			}
		}

		System.Boolean _BoolFive;
		public System.Boolean BoolFive
		{
			get
			{
				return _BoolFive;
			}

			set
			{
				if (_BoolFive != value)
				{
					_BoolFive = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BoolFive)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stBools target)
		{
			target.BoolOne.Cyclic = BoolOne;
			target.BoolTwo.Cyclic = BoolTwo;
			target.BoolThree.Cyclic = BoolThree;
			target.BoolFive.Cyclic = BoolFive;
		}

		public void CopyPlainToCyclic(Plc.IstBools target)
		{
			this.CopyPlainToCyclic((Plc.stBools)target);
		}

		public void CopyPlainToShadow(Plc.stBools target)
		{
			target.BoolOne.Shadow = BoolOne;
			target.BoolTwo.Shadow = BoolTwo;
			target.BoolThree.Shadow = BoolThree;
			target.BoolFive.Shadow = BoolFive;
		}

		public void CopyPlainToShadow(Plc.IShadowstBools target)
		{
			this.CopyPlainToShadow((Plc.stBools)target);
		}

		public void CopyCyclicToPlain(Plc.stBools source)
		{
			BoolOne = source.BoolOne.LastValue;
			BoolTwo = source.BoolTwo.LastValue;
			BoolThree = source.BoolThree.LastValue;
			BoolFive = source.BoolFive.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IstBools source)
		{
			this.CopyCyclicToPlain((Plc.stBools)source);
		}

		public void CopyShadowToPlain(Plc.stBools source)
		{
			BoolOne = source.BoolOne.Shadow;
			BoolTwo = source.BoolTwo.Shadow;
			BoolThree = source.BoolThree.Shadow;
			BoolFive = source.BoolFive.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowstBools source)
		{
			this.CopyShadowToPlain((Plc.stBools)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstBools()
		{
		}
	}
}