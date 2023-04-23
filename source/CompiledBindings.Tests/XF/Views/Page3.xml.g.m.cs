namespace XFTest.Views
{
#nullable disable

	[global::System.CodeDom.Compiler.GeneratedCode("CompiledBindings", null)]
	partial class Page3
	{
		private global::Xamarin.Forms.Label label2;
		private global::Xamarin.Forms.Label label3;
		private global::Xamarin.Forms.Label label4;
		private global::Xamarin.Forms.Label label5;
		private global::Xamarin.Forms.Label label6;
		private global::Xamarin.Forms.Label label7;
		private bool _generatedCodeInitialized;

		private void InitializeAfterConstructor()
		{
			if (_generatedCodeInitialized)
				return;

			_generatedCodeInitialized = true;

			label2 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label2");
			label3 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label3");
			label4 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label4");
			label5 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label5");
			label6 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label6");
			label7 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "label7");

#line (34, 13) - (34, 28) 34 "Page3.xml"
			label5.Text = 3.ToString();
#line default

			this.BindingContextChanged += this_BindingContextChanged;
			if (this.BindingContext is global::XFTest.ViewModels.Page3ViewModel dataRoot0)
			{
				Bindings_this.Initialize(this, dataRoot0);
			}
		}

		private void this_BindingContextChanged(object sender, global::System.EventArgs e)
		{
			Bindings_this.Cleanup();
			if (((global::Xamarin.Forms.Element)sender).BindingContext is global::XFTest.ViewModels.Page3ViewModel dataRoot)
			{
				Bindings_this.Initialize(this, dataRoot);
			}
		}

		Page3_Bindings_this Bindings_this = new Page3_Bindings_this();

		class Page3_Bindings_this
		{
			Page3 _targetRoot;
			global::XFTest.ViewModels.Page3ViewModel _dataRoot;
			Page3_BindingsTrackings_this _bindingsTrackings;

			public void Initialize(Page3 targetRoot, global::XFTest.ViewModels.Page3ViewModel dataRoot)
			{
				_targetRoot = targetRoot;
				_dataRoot = dataRoot;
				_bindingsTrackings = new Page3_BindingsTrackings_this(this);

				Update();

				_bindingsTrackings.SetPropertyChangedEventHandler0(dataRoot);
			}

			public void Cleanup()
			{
				if (_targetRoot != null)
				{
					_bindingsTrackings.Cleanup();
					_dataRoot = null;
					_targetRoot = null;
				}
			}

			public void Update()
			{
				var dataRoot = _dataRoot;
#line (33, 13) - (33, 46) 33 "Page3.xml"
				_targetRoot.ItemsSource = dataRoot.PickedItems;
#line default
				Update0(dataRoot);
			}

			private void Update0(global::XFTest.ViewModels.Page3ViewModel value)
			{
				Update0_Entity(value);
				Update0_State(value);
			}

			private void Update1(global::XFTest.ViewModels.EntityModel value)
			{
				Update1_SByteProp(value);
				Update1_UShortProp(value);
				Update1__field1(value);
			}

			private void Update0_Entity(global::XFTest.ViewModels.Page3ViewModel value)
			{
#line (28, 16) - (28, 64) 28 "Page3.xml"
				var value1 = value.Entity;
#line (28, 16) - (28, 64) 28 "Page3.xml"
				_targetRoot.label2.IsVisible = value1 != null && value.IsLoading;
#line default
				Update1(value1);
				_bindingsTrackings.SetPropertyChangedEventHandler1(value1);
			}

			private void Update0_IsLoading(global::XFTest.ViewModels.Page3ViewModel value)
			{
#line (28, 16) - (28, 64) 28 "Page3.xml"
				_targetRoot.label2.IsVisible = value.Entity != null && value.IsLoading;
#line default
			}

			private void Update0_State(global::XFTest.ViewModels.Page3ViewModel value)
			{
#line (35, 13) - (35, 43) 35 "Page3.xml"
				_targetRoot.label6.Text = value[1, "test"].ToString();
#line default
			}

			private void Update1_SByteProp(global::XFTest.ViewModels.EntityModel value)
			{
#line (29, 16) - (29, 47) 29 "Page3.xml"
				_targetRoot.label3.Text = value?.SByteProp.ToString();
#line default
			}

			private void Update1_UShortProp(global::XFTest.ViewModels.EntityModel value)
			{
#line (30, 16) - (30, 48) 30 "Page3.xml"
				_targetRoot.label4.Text = value?.UShortProp.ToString();
#line default
			}

			private void Update1__field1(global::XFTest.ViewModels.EntityModel value)
			{
#line (36, 13) - (36, 43) 36 "Page3.xml"
				_targetRoot.label7.Text = value?._field1.ToString();
#line default
			}

			class Page3_BindingsTrackings_this
			{
				global::System.WeakReference _bindingsWeakRef;
				global::XFTest.ViewModels.Page3ViewModel _propertyChangeSource0;
				global::XFTest.ViewModels.EntityModel _propertyChangeSource1;

				public Page3_BindingsTrackings_this(Page3_Bindings_this bindings)
				{
					_bindingsWeakRef = new global::System.WeakReference(bindings);
				}

				public void Cleanup()
				{
					SetPropertyChangedEventHandler0(null);
					SetPropertyChangedEventHandler1(null);
				}

				public void SetPropertyChangedEventHandler0(global::XFTest.ViewModels.Page3ViewModel value)
				{
					if (_propertyChangeSource0 != null && !object.ReferenceEquals(_propertyChangeSource0, value))
					{
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource0).PropertyChanged -= OnPropertyChanged0;
						_propertyChangeSource0 = null;
					}
					if (_propertyChangeSource0 == null && value != null)
					{
						_propertyChangeSource0 = value;
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource0).PropertyChanged += OnPropertyChanged0;
					}
				}

				public void SetPropertyChangedEventHandler1(global::XFTest.ViewModels.EntityModel value)
				{
					if (_propertyChangeSource1 != null && !object.ReferenceEquals(_propertyChangeSource1, value))
					{
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource1).PropertyChanged -= OnPropertyChanged1;
						_propertyChangeSource1 = null;
					}
					if (_propertyChangeSource1 == null && value != null)
					{
						_propertyChangeSource1 = value;
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource1).PropertyChanged += OnPropertyChanged1;
					}
				}

				private void OnPropertyChanged0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					var bindings = TryGetBindings();
					if (bindings == null)
					{
						return;
					}

					var typedSender = (global::XFTest.ViewModels.Page3ViewModel)sender;
					switch (e.PropertyName)
					{
						case null:
						case "":
							bindings.Update0(typedSender);
							break;
						case "Entity":
							bindings.Update0_Entity(typedSender);
							break;
						case "IsLoading":
							bindings.Update0_IsLoading(typedSender);
							break;
						case "State":
						case "Items[]":
							bindings.Update0_State(typedSender);
							break;
					}
				}

				private void OnPropertyChanged1(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					var bindings = TryGetBindings();
					if (bindings == null)
					{
						return;
					}

					var typedSender = (global::XFTest.ViewModels.EntityModel)sender;
					switch (e.PropertyName)
					{
						case null:
						case "":
							bindings.Update1(typedSender);
							break;
						case "SByteProp":
							bindings.Update1_SByteProp(typedSender);
							break;
						case "UShortProp":
							bindings.Update1_UShortProp(typedSender);
							break;
						case "_field1":
							bindings.Update1__field1(typedSender);
							break;
					}
				}

				Page3_Bindings_this TryGetBindings()
				{
					Page3_Bindings_this bindings = null;
					if (_bindingsWeakRef != null)
					{
						bindings = (Page3_Bindings_this)_bindingsWeakRef.Target;
						if (bindings == null)
						{
							_bindingsWeakRef = null;
							Cleanup();
						}
					}
					return bindings;
				}
			}
		}
	}

	class Page3__ItemDisplayBinding : global::Xamarin.Forms.Xaml.IMarkupExtension
	{
		global::Xamarin.Forms.Internals.TypedBindingBase _binding = new global::Xamarin.Forms.Internals.TypedBinding<global::XFTest.ViewModels.PickItem, global::System.String>(
			dataRoot => dataRoot == null ? (default, false) : (
#line (32, 13) - (32, 83) 32 "Page3.xml"
				dataRoot.Description,
#line default
				true),
			null,
			new[]
			{
				new global::System.Tuple<global::System.Func<global::XFTest.ViewModels.PickItem, object>, string>(dataRoot =>
#line (32, 13) - (32, 83) 32 "Page3.xml"
					dataRoot,
#line default
					"Description"),
			});

		public object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			return _binding;
		}
	}

	class Page3_DataTemplate0 : global::CompiledBindings.IGeneratedDataTemplate
	{
		private global::Xamarin.Forms.Label label1;

		public void Initialize(global::Xamarin.Forms.Element rootElement)
		{
			label1 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(rootElement, "label1");


			rootElement.BindingContextChanged += rootElement_BindingContextChanged;
			if (rootElement.BindingContext is global::XFTest.ViewModels.EntityViewModel dataRoot0)
			{
				Bindings_rootElement.Initialize(this, dataRoot0);
			}
		}

		public void Cleanup(global::Xamarin.Forms.Element rootElement)
		{
			rootElement.BindingContextChanged -= rootElement_BindingContextChanged;
			Bindings_rootElement.Cleanup();
		}

		private void rootElement_BindingContextChanged(object sender, global::System.EventArgs e)
		{
			Bindings_rootElement.Cleanup();
			if (((global::Xamarin.Forms.Element)sender).BindingContext is global::XFTest.ViewModels.EntityViewModel dataRoot)
			{
				Bindings_rootElement.Initialize(this, dataRoot);
			}
		}

		Page3_DataTemplate0_Bindings_rootElement Bindings_rootElement = new Page3_DataTemplate0_Bindings_rootElement();

		class Page3_DataTemplate0_Bindings_rootElement
		{
			Page3_DataTemplate0 _targetRoot;
			global::XFTest.ViewModels.EntityViewModel _dataRoot;
			Page3_DataTemplate0_BindingsTrackings_rootElement _bindingsTrackings;

			public void Initialize(Page3_DataTemplate0 targetRoot, global::XFTest.ViewModels.EntityViewModel dataRoot)
			{
				_targetRoot = targetRoot;
				_dataRoot = dataRoot;
				_bindingsTrackings = new Page3_DataTemplate0_BindingsTrackings_rootElement(this);

				Update();

				_bindingsTrackings.SetPropertyChangedEventHandler0(dataRoot);
			}

			public void Cleanup()
			{
				if (_targetRoot != null)
				{
					_bindingsTrackings.Cleanup();
					_dataRoot = null;
					_targetRoot = null;
				}
			}

			public void Update()
			{
				var dataRoot = _dataRoot;
				Update0_Item(dataRoot);
			}

			private void Update0_Item(global::XFTest.ViewModels.EntityViewModel value)
			{
#line (22, 15) - (22, 38) 22 "Page3.xml"
				_targetRoot.label1.Text = value[0];
#line default
			}

			class Page3_DataTemplate0_BindingsTrackings_rootElement
			{
				global::System.WeakReference _bindingsWeakRef;
				global::XFTest.ViewModels.EntityViewModel _propertyChangeSource0;

				public Page3_DataTemplate0_BindingsTrackings_rootElement(Page3_DataTemplate0_Bindings_rootElement bindings)
				{
					_bindingsWeakRef = new global::System.WeakReference(bindings);
				}

				public void Cleanup()
				{
					SetPropertyChangedEventHandler0(null);
				}

				public void SetPropertyChangedEventHandler0(global::XFTest.ViewModels.EntityViewModel value)
				{
					if (_propertyChangeSource0 != null && !object.ReferenceEquals(_propertyChangeSource0, value))
					{
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource0).PropertyChanged -= OnPropertyChanged0;
						_propertyChangeSource0 = null;
					}
					if (_propertyChangeSource0 == null && value != null)
					{
						_propertyChangeSource0 = value;
						((System.ComponentModel.INotifyPropertyChanged)_propertyChangeSource0).PropertyChanged += OnPropertyChanged0;
					}
				}

				private void OnPropertyChanged0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					var bindings = TryGetBindings();
					if (bindings == null)
					{
						return;
					}

					var typedSender = (global::XFTest.ViewModels.EntityViewModel)sender;
					if (string.IsNullOrEmpty(e.PropertyName) || e.PropertyName == "Item" || e.PropertyName == "Items[]")
					{
						bindings.Update0_Item(typedSender);
					}
				}

				Page3_DataTemplate0_Bindings_rootElement TryGetBindings()
				{
					Page3_DataTemplate0_Bindings_rootElement bindings = null;
					if (_bindingsWeakRef != null)
					{
						bindings = (Page3_DataTemplate0_Bindings_rootElement)_bindingsWeakRef.Target;
						if (bindings == null)
						{
							_bindingsWeakRef = null;
							Cleanup();
						}
					}
					return bindings;
				}
			}
		}
	}

	class Page3_DataTemplate0__ItemDisplayBinding : global::Xamarin.Forms.Xaml.IMarkupExtension
	{
		global::Xamarin.Forms.Internals.TypedBindingBase _binding = new global::Xamarin.Forms.Internals.TypedBinding<global::XFTest.ViewModels.EntityModel, global::System.SByte>(
			dataRoot => dataRoot == null ? (default, false) : (
#line (21, 23) - (21, 94) 21 "Page3.xml"
				dataRoot.SByteProp,
#line default
				true),
			null,
			new[]
			{
				new global::System.Tuple<global::System.Func<global::XFTest.ViewModels.EntityModel, object>, string>(dataRoot =>
#line (21, 23) - (21, 94) 21 "Page3.xml"
					dataRoot,
#line default
					"SByteProp"),
			});

		public object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			return _binding;
		}
	}
}
