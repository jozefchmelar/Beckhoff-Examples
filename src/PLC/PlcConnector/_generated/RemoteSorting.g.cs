using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "RemoteSorting", "Plc", TypeComplexityEnum.Complex)]
	public partial class RemoteSorting : Vortex.Connector.IVortexObject, IRemoteSorting, IShadowRemoteSorting, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		public Vortex.Connector.ValueTypes.OnlinerInt[] MyArray
		{
			get;
			set;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt[] IRemoteSorting.MyArray
		{
			get
			{
				return MyArray;
			}

			set
			{
				MyArray = (Vortex.Connector.ValueTypes.OnlinerInt[])value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt[] IShadowRemoteSorting.MyArray
		{
			get
			{
				return MyArray;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _MyArrayToString;
		public Vortex.Connector.ValueTypes.OnlinerString MyArrayToString
		{
			get
			{
				return _MyArrayToString;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IRemoteSorting.MyArrayToString
		{
			get
			{
				return MyArrayToString;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowRemoteSorting.MyArrayToString
		{
			get
			{
				return MyArrayToString;
			}
		}

		CSharpMethod _Sort;
		public CSharpMethod Sort
		{
			get
			{
				return _Sort;
			}
		}

		ICSharpMethod IRemoteSorting.Sort
		{
			get
			{
				return Sort;
			}
		}

		IShadowCSharpMethod IShadowRemoteSorting.Sort
		{
			get
			{
				return Sort;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _InitArray;
		public Vortex.Connector.ValueTypes.OnlinerBool InitArray
		{
			get
			{
				return _InitArray;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IRemoteSorting.InitArray
		{
			get
			{
				return InitArray;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowRemoteSorting.InitArray
		{
			get
			{
				return InitArray;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _i;
		[RenderIgnore()]
		public Vortex.Connector.ValueTypes.OnlinerInt i
		{
			get
			{
				return _i;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IRemoteSorting.i
		{
			get
			{
				return i;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowRemoteSorting.i
		{
			get
			{
				return i;
			}
		}

		public void LazyOnlineToShadow()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(MyArray);
			MyArrayToString.Shadow = MyArrayToString.LastValue;
			Sort.LazyOnlineToShadow();
			InitArray.Shadow = InitArray.LastValue;
			i.Shadow = i.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(MyArray);
			MyArrayToString.Cyclic = MyArrayToString.Shadow;
			Sort.LazyShadowToOnline();
			InitArray.Cyclic = InitArray.Shadow;
			i.Cyclic = i.Shadow;
		}

		public PlainRemoteSorting CreatePlainerType()
		{
			var cloned = new PlainRemoteSorting();
			cloned.MyArray = new System.Int16[11];
			cloned.Sort = Sort.CreatePlainerType();
			return cloned;
		}

		protected PlainRemoteSorting CreatePlainerType(PlainRemoteSorting cloned)
		{
			cloned.MyArray = new System.Int16[11];
			cloned.Sort = Sort.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainRemoteSorting source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainRemoteSorting source)
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

		public void FlushOnlineToPlain(Plc.PlainRemoteSorting source)
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

		public RemoteSorting(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			MyArray = new Vortex.Connector.ValueTypes.OnlinerInt[11];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(MyArray, this, "", "MyArray", (p, rt, st) => @Connector.Online.Adapter.CreateINT(p, rt, st));
			_MyArrayToString = @Connector.Online.Adapter.CreateSTRING(this, "", "MyArrayToString");
			_Sort = new CSharpMethod(this, "Sort", "Sort");
			_Sort.AttributeName = "Sort";
			_InitArray = @Connector.Online.Adapter.CreateBOOL(this, "", "InitArray");
			_i = @Connector.Online.Adapter.CreateINT(this, "", "i");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public RemoteSorting()
		{
			PexPreConstructorParameterless();
			MyArray = new Vortex.Connector.ValueTypes.OnlinerInt[11];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(MyArray, () => Vortex.Connector.IConnectorFactory.CreateINT());
			_MyArrayToString = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Sort = new CSharpMethod();
			_Sort.AttributeName = "Sort";
			_InitArray = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcRemoteSorting
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcRemoteSorting()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IRemoteSorting : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt[] MyArray
		{
			get;
			set;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString MyArrayToString
		{
			get;
		}

		ICSharpMethod Sort
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool InitArray
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineInt i
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainRemoteSorting CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainRemoteSorting source);
		void FlushOnlineToPlain(Plc.PlainRemoteSorting source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowRemoteSorting : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt[] MyArray
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString MyArrayToString
		{
			get;
		}

		IShadowCSharpMethod Sort
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool InitArray
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt i
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainRemoteSorting CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainRemoteSorting source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainRemoteSorting : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		public System.Int16[] MyArray
		{
			get;
			set;
		}

		System.String _MyArrayToString;
		public System.String MyArrayToString
		{
			get
			{
				return _MyArrayToString;
			}

			set
			{
				if (_MyArrayToString != value)
				{
					_MyArrayToString = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MyArrayToString)));
				}
			}
		}

		PlainCSharpMethod _Sort;
		public PlainCSharpMethod Sort
		{
			get
			{
				return _Sort;
			}

			set
			{
				if (_Sort != value)
				{
					_Sort = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Sort)));
				}
			}
		}

		System.Boolean _InitArray;
		public System.Boolean InitArray
		{
			get
			{
				return _InitArray;
			}

			set
			{
				if (_InitArray != value)
				{
					_InitArray = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InitArray)));
				}
			}
		}

		System.Int16 _i;
		[RenderIgnore()]
		public System.Int16 i
		{
			get
			{
				return _i;
			}

			set
			{
				if (_i != value)
				{
					_i = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.RemoteSorting target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(MyArray, target.MyArray);
			target.MyArrayToString.Cyclic = MyArrayToString;
			Sort.CopyPlainToCyclic(target.Sort);
			target.InitArray.Cyclic = InitArray;
			target.i.Cyclic = i;
		}

		public void CopyPlainToCyclic(Plc.IRemoteSorting target)
		{
			this.CopyPlainToCyclic((Plc.RemoteSorting)target);
		}

		public void CopyPlainToShadow(Plc.RemoteSorting target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(MyArray, target.MyArray);
			target.MyArrayToString.Shadow = MyArrayToString;
			Sort.CopyPlainToShadow(target.Sort);
			target.InitArray.Shadow = InitArray;
			target.i.Shadow = i;
		}

		public void CopyPlainToShadow(Plc.IShadowRemoteSorting target)
		{
			this.CopyPlainToShadow((Plc.RemoteSorting)target);
		}

		public void CopyCyclicToPlain(Plc.RemoteSorting source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.MyArray, MyArray);
			MyArrayToString = source.MyArrayToString.LastValue;
			Sort.CopyCyclicToPlain(source.Sort);
			InitArray = source.InitArray.LastValue;
			i = source.i.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IRemoteSorting source)
		{
			this.CopyCyclicToPlain((Plc.RemoteSorting)source);
		}

		public void CopyShadowToPlain(Plc.RemoteSorting source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.MyArray, MyArray);
			MyArrayToString = source.MyArrayToString.Shadow;
			Sort.CopyShadowToPlain(source.Sort);
			InitArray = source.InitArray.Shadow;
			i = source.i.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowRemoteSorting source)
		{
			this.CopyShadowToPlain((Plc.RemoteSorting)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainRemoteSorting()
		{
			MyArray = new System.Int16[11];
			_Sort = new PlainCSharpMethod();
		}
	}
}