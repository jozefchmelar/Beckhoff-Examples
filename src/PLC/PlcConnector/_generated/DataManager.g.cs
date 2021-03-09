using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "DataManager", "Plc", TypeComplexityEnum.Complex)]
	public partial class DataManager : Vortex.Connector.IVortexObject, IDataManager, IShadowDataManager, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stSettings _Settings;
		public stSettings Settings
		{
			get
			{
				return _Settings;
			}
		}

		IstSettings IDataManager.Settings
		{
			get
			{
				return Settings;
			}
		}

		IShadowstSettings IShadowDataManager.Settings
		{
			get
			{
				return Settings;
			}
		}

		CSharpMethod _SaveSettings;
		public CSharpMethod SaveSettings
		{
			get
			{
				return _SaveSettings;
			}
		}

		ICSharpMethod IDataManager.SaveSettings
		{
			get
			{
				return SaveSettings;
			}
		}

		IShadowCSharpMethod IShadowDataManager.SaveSettings
		{
			get
			{
				return SaveSettings;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Invoke;
		[RenderIgnore()]
		public Vortex.Connector.ValueTypes.OnlinerBool Invoke
		{
			get
			{
				return _Invoke;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IDataManager.Invoke
		{
			get
			{
				return Invoke;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowDataManager.Invoke
		{
			get
			{
				return Invoke;
			}
		}

		public void LazyOnlineToShadow()
		{
			Settings.LazyOnlineToShadow();
			SaveSettings.LazyOnlineToShadow();
			Invoke.Shadow = Invoke.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Settings.LazyShadowToOnline();
			SaveSettings.LazyShadowToOnline();
			Invoke.Cyclic = Invoke.Shadow;
		}

		public PlainDataManager CreatePlainerType()
		{
			var cloned = new PlainDataManager();
			cloned.Settings = Settings.CreatePlainerType();
			cloned.SaveSettings = SaveSettings.CreatePlainerType();
			return cloned;
		}

		protected PlainDataManager CreatePlainerType(PlainDataManager cloned)
		{
			cloned.Settings = Settings.CreatePlainerType();
			cloned.SaveSettings = SaveSettings.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
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

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

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

		public void FlushPlainToOnline(Plc.PlainDataManager source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainDataManager source)
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

		public void FlushOnlineToPlain(Plc.PlainDataManager source)
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

		public DataManager(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Settings = new stSettings(this, "", "Settings");
			_SaveSettings = new CSharpMethod(this, "Save to database", "SaveSettings");
			_SaveSettings.AttributeName = "Save to database";
			_Invoke = @Connector.Online.Adapter.CreateBOOL(this, "", "Invoke");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public DataManager()
		{
			PexPreConstructorParameterless();
			_Settings = new stSettings();
			_SaveSettings = new CSharpMethod();
			_SaveSettings.AttributeName = "Save to database";
			_Invoke = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcDataManager
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcDataManager()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IDataManager : Vortex.Connector.IVortexOnlineObject
	{
		IstSettings Settings
		{
			get;
		}

		ICSharpMethod SaveSettings
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineBool Invoke
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainDataManager CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainDataManager source);
		void FlushOnlineToPlain(Plc.PlainDataManager source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowDataManager : Vortex.Connector.IVortexShadowObject
	{
		IShadowstSettings Settings
		{
			get;
		}

		IShadowCSharpMethod SaveSettings
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Invoke
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainDataManager CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainDataManager source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDataManager : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstSettings _Settings;
		public PlainstSettings Settings
		{
			get
			{
				return _Settings;
			}

			set
			{
				if (_Settings != value)
				{
					_Settings = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Settings)));
				}
			}
		}

		PlainCSharpMethod _SaveSettings;
		public PlainCSharpMethod SaveSettings
		{
			get
			{
				return _SaveSettings;
			}

			set
			{
				if (_SaveSettings != value)
				{
					_SaveSettings = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SaveSettings)));
				}
			}
		}

		System.Boolean _Invoke;
		[RenderIgnore()]
		public System.Boolean Invoke
		{
			get
			{
				return _Invoke;
			}

			set
			{
				if (_Invoke != value)
				{
					_Invoke = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Invoke)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.DataManager target)
		{
			Settings.CopyPlainToCyclic(target.Settings);
			SaveSettings.CopyPlainToCyclic(target.SaveSettings);
			target.Invoke.Cyclic = Invoke;
		}

		public void CopyPlainToCyclic(Plc.IDataManager target)
		{
			this.CopyPlainToCyclic((Plc.DataManager)target);
		}

		public void CopyPlainToShadow(Plc.DataManager target)
		{
			Settings.CopyPlainToShadow(target.Settings);
			SaveSettings.CopyPlainToShadow(target.SaveSettings);
			target.Invoke.Shadow = Invoke;
		}

		public void CopyPlainToShadow(Plc.IShadowDataManager target)
		{
			this.CopyPlainToShadow((Plc.DataManager)target);
		}

		public void CopyCyclicToPlain(Plc.DataManager source)
		{
			Settings.CopyCyclicToPlain(source.Settings);
			SaveSettings.CopyCyclicToPlain(source.SaveSettings);
			Invoke = source.Invoke.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IDataManager source)
		{
			this.CopyCyclicToPlain((Plc.DataManager)source);
		}

		public void CopyShadowToPlain(Plc.DataManager source)
		{
			Settings.CopyShadowToPlain(source.Settings);
			SaveSettings.CopyShadowToPlain(source.SaveSettings);
			Invoke = source.Invoke.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowDataManager source)
		{
			this.CopyShadowToPlain((Plc.DataManager)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainDataManager()
		{
			_Settings = new PlainstSettings();
			_SaveSettings = new PlainCSharpMethod();
		}
	}
}