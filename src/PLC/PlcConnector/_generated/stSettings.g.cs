using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stSettings", "Plc", TypeComplexityEnum.Complex)]
	public partial class stSettings : stEntity, Vortex.Connector.IVortexObject, IstSettings, IShadowstSettings, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerBool _One;
		public Vortex.Connector.ValueTypes.OnlinerBool One
		{
			get
			{
				return _One;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstSettings.One
		{
			get
			{
				return One;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstSettings.One
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstSettings.Two
		{
			get
			{
				return Two;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstSettings.Two
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IstSettings.Another
		{
			get
			{
				return Another;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstSettings.Another
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IstSettings.ThisOne
		{
			get
			{
				return ThisOne;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstSettings.ThisOne
		{
			get
			{
				return ThisOne;
			}
		}

		stBools _bools;
		public stBools bools
		{
			get
			{
				return _bools;
			}
		}

		IstBools IstSettings.bools
		{
			get
			{
				return bools;
			}
		}

		IShadowstBools IShadowstSettings.bools
		{
			get
			{
				return bools;
			}
		}

		stTreeStruct _trees;
		public stTreeStruct trees
		{
			get
			{
				return _trees;
			}
		}

		IstTreeStruct IstSettings.trees
		{
			get
			{
				return trees;
			}
		}

		IShadowstTreeStruct IShadowstSettings.trees
		{
			get
			{
				return trees;
			}
		}

		stBools _xbools;
		public stBools xbools
		{
			get
			{
				return _xbools;
			}
		}

		IstBools IstSettings.xbools
		{
			get
			{
				return xbools;
			}
		}

		IShadowstBools IShadowstSettings.xbools
		{
			get
			{
				return xbools;
			}
		}

		stTreeStruct _atrees;
		public stTreeStruct atrees
		{
			get
			{
				return _atrees;
			}
		}

		IstTreeStruct IstSettings.atrees
		{
			get
			{
				return atrees;
			}
		}

		IShadowstTreeStruct IShadowstSettings.atrees
		{
			get
			{
				return atrees;
			}
		}

		stBools _sbools;
		public stBools sbools
		{
			get
			{
				return _sbools;
			}
		}

		IstBools IstSettings.sbools
		{
			get
			{
				return sbools;
			}
		}

		IShadowstBools IShadowstSettings.sbools
		{
			get
			{
				return sbools;
			}
		}

		stTreeStruct _ttrees;
		public stTreeStruct ttrees
		{
			get
			{
				return _ttrees;
			}
		}

		IstTreeStruct IstSettings.ttrees
		{
			get
			{
				return ttrees;
			}
		}

		IShadowstTreeStruct IShadowstSettings.ttrees
		{
			get
			{
				return ttrees;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			One.Shadow = One.LastValue;
			Two.Shadow = Two.LastValue;
			Another.Shadow = Another.LastValue;
			ThisOne.Shadow = ThisOne.LastValue;
			bools.LazyOnlineToShadow();
			trees.LazyOnlineToShadow();
			xbools.LazyOnlineToShadow();
			atrees.LazyOnlineToShadow();
			sbools.LazyOnlineToShadow();
			ttrees.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			One.Cyclic = One.Shadow;
			Two.Cyclic = Two.Shadow;
			Another.Cyclic = Another.Shadow;
			ThisOne.Cyclic = ThisOne.Shadow;
			bools.LazyShadowToOnline();
			trees.LazyShadowToOnline();
			xbools.LazyShadowToOnline();
			atrees.LazyShadowToOnline();
			sbools.LazyShadowToOnline();
			ttrees.LazyShadowToOnline();
		}

		public new PlainstSettings CreatePlainerType()
		{
			var cloned = new PlainstSettings();
			base.CreatePlainerType(cloned);
			cloned.bools = bools.CreatePlainerType();
			cloned.trees = trees.CreatePlainerType();
			cloned.xbools = xbools.CreatePlainerType();
			cloned.atrees = atrees.CreatePlainerType();
			cloned.sbools = sbools.CreatePlainerType();
			cloned.ttrees = ttrees.CreatePlainerType();
			return cloned;
		}

		protected PlainstSettings CreatePlainerType(PlainstSettings cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.bools = bools.CreatePlainerType();
			cloned.trees = trees.CreatePlainerType();
			cloned.xbools = xbools.CreatePlainerType();
			cloned.atrees = atrees.CreatePlainerType();
			cloned.sbools = sbools.CreatePlainerType();
			cloned.ttrees = ttrees.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc.PlainstSettings source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstSettings source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainstSettings source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public stSettings(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_One = @Connector.Online.Adapter.CreateBOOL(this, "", "One");
			_Two = @Connector.Online.Adapter.CreateBOOL(this, "", "Two");
			_Another = @Connector.Online.Adapter.CreateSTRING(this, "", "Another");
			_ThisOne = @Connector.Online.Adapter.CreateSTRING(this, "", "ThisOne");
			_bools = new stBools(this, "", "bools");
			_trees = new stTreeStruct(this, "", "trees");
			_xbools = new stBools(this, "", "xbools");
			_atrees = new stTreeStruct(this, "", "atrees");
			_sbools = new stBools(this, "", "sbools");
			_ttrees = new stTreeStruct(this, "", "ttrees");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stSettings(): base ()
		{
			PexPreConstructorParameterless();
			_One = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_Two = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_Another = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_ThisOne = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_bools = new stBools();
			_trees = new stTreeStruct();
			_xbools = new stBools();
			_atrees = new stTreeStruct();
			_sbools = new stBools();
			_ttrees = new stTreeStruct();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstSettings : Plc.stEntity.PlcstEntity
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstSettings()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstSettings : Vortex.Connector.IVortexOnlineObject, Plc.IstEntity
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

		IstBools bools
		{
			get;
		}

		IstTreeStruct trees
		{
			get;
		}

		IstBools xbools
		{
			get;
		}

		IstTreeStruct atrees
		{
			get;
		}

		IstBools sbools
		{
			get;
		}

		IstTreeStruct ttrees
		{
			get;
		}

		new Plc.PlainstSettings CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstSettings source);
		void FlushOnlineToPlain(Plc.PlainstSettings source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstSettings : Vortex.Connector.IVortexShadowObject, Plc.IShadowstEntity
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

		IShadowstBools bools
		{
			get;
		}

		IShadowstTreeStruct trees
		{
			get;
		}

		IShadowstBools xbools
		{
			get;
		}

		IShadowstTreeStruct atrees
		{
			get;
		}

		IShadowstBools sbools
		{
			get;
		}

		IShadowstTreeStruct ttrees
		{
			get;
		}

		new Plc.PlainstSettings CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstSettings source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstSettings : Plc.PlainstEntity
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

		PlainstBools _bools;
		public PlainstBools bools
		{
			get
			{
				return _bools;
			}

			set
			{
				if (_bools != value)
				{
					_bools = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bools)));
				}
			}
		}

		PlainstTreeStruct _trees;
		public PlainstTreeStruct trees
		{
			get
			{
				return _trees;
			}

			set
			{
				if (_trees != value)
				{
					_trees = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(trees)));
				}
			}
		}

		PlainstBools _xbools;
		public PlainstBools xbools
		{
			get
			{
				return _xbools;
			}

			set
			{
				if (_xbools != value)
				{
					_xbools = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(xbools)));
				}
			}
		}

		PlainstTreeStruct _atrees;
		public PlainstTreeStruct atrees
		{
			get
			{
				return _atrees;
			}

			set
			{
				if (_atrees != value)
				{
					_atrees = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(atrees)));
				}
			}
		}

		PlainstBools _sbools;
		public PlainstBools sbools
		{
			get
			{
				return _sbools;
			}

			set
			{
				if (_sbools != value)
				{
					_sbools = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(sbools)));
				}
			}
		}

		PlainstTreeStruct _ttrees;
		public PlainstTreeStruct ttrees
		{
			get
			{
				return _ttrees;
			}

			set
			{
				if (_ttrees != value)
				{
					_ttrees = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ttrees)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stSettings target)
		{
			base.CopyPlainToCyclic(target);
			target.One.Cyclic = One;
			target.Two.Cyclic = Two;
			target.Another.Cyclic = Another;
			target.ThisOne.Cyclic = ThisOne;
			bools.CopyPlainToCyclic(target.bools);
			trees.CopyPlainToCyclic(target.trees);
			xbools.CopyPlainToCyclic(target.xbools);
			atrees.CopyPlainToCyclic(target.atrees);
			sbools.CopyPlainToCyclic(target.sbools);
			ttrees.CopyPlainToCyclic(target.ttrees);
		}

		public void CopyPlainToCyclic(Plc.IstSettings target)
		{
			this.CopyPlainToCyclic((Plc.stSettings)target);
		}

		public void CopyPlainToShadow(Plc.stSettings target)
		{
			base.CopyPlainToShadow(target);
			target.One.Shadow = One;
			target.Two.Shadow = Two;
			target.Another.Shadow = Another;
			target.ThisOne.Shadow = ThisOne;
			bools.CopyPlainToShadow(target.bools);
			trees.CopyPlainToShadow(target.trees);
			xbools.CopyPlainToShadow(target.xbools);
			atrees.CopyPlainToShadow(target.atrees);
			sbools.CopyPlainToShadow(target.sbools);
			ttrees.CopyPlainToShadow(target.ttrees);
		}

		public void CopyPlainToShadow(Plc.IShadowstSettings target)
		{
			this.CopyPlainToShadow((Plc.stSettings)target);
		}

		public void CopyCyclicToPlain(Plc.stSettings source)
		{
			base.CopyCyclicToPlain(source);
			One = source.One.LastValue;
			Two = source.Two.LastValue;
			Another = source.Another.LastValue;
			ThisOne = source.ThisOne.LastValue;
			bools.CopyCyclicToPlain(source.bools);
			trees.CopyCyclicToPlain(source.trees);
			xbools.CopyCyclicToPlain(source.xbools);
			atrees.CopyCyclicToPlain(source.atrees);
			sbools.CopyCyclicToPlain(source.sbools);
			ttrees.CopyCyclicToPlain(source.ttrees);
		}

		public void CopyCyclicToPlain(Plc.IstSettings source)
		{
			this.CopyCyclicToPlain((Plc.stSettings)source);
		}

		public void CopyShadowToPlain(Plc.stSettings source)
		{
			base.CopyShadowToPlain(source);
			One = source.One.Shadow;
			Two = source.Two.Shadow;
			Another = source.Another.Shadow;
			ThisOne = source.ThisOne.Shadow;
			bools.CopyShadowToPlain(source.bools);
			trees.CopyShadowToPlain(source.trees);
			xbools.CopyShadowToPlain(source.xbools);
			atrees.CopyShadowToPlain(source.atrees);
			sbools.CopyShadowToPlain(source.sbools);
			ttrees.CopyShadowToPlain(source.ttrees);
		}

		public void CopyShadowToPlain(Plc.IShadowstSettings source)
		{
			this.CopyShadowToPlain((Plc.stSettings)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstSettings()
		{
			_bools = new PlainstBools();
			_trees = new PlainstTreeStruct();
			_xbools = new PlainstBools();
			_atrees = new PlainstTreeStruct();
			_sbools = new PlainstBools();
			_ttrees = new PlainstTreeStruct();
		}
	}
}