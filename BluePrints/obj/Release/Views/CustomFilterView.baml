   M S B A M L   `   `   `  ����   
BluePrints'    !BluePrints.Views.CustomFilterView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aH 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  ] YDevExpress.Mvvm.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   <d2http://schemas.microsoft.com/expression/blend/2008   .��]� $��
12,12,12,0q�.+�%  DevExpress.Xpf.Editors.TextEdit  %  DevExpress.Xpf.Editors.BaseEdit    NullText$,  &Enter a name for your custom filter...��$��Bottom=�   	EditValue �� *
FilterName+�� $��Bottom=�$
��Left=�$
��0,10q�.+�&   DevExpress.Xpf.Editors.CheckEdit     Content)  #DevExpress.Xpf.Core.ObjectConverter$ Save for future use  �� *Save+4  .DevExpress.Xpf.Editors.Filtering.FilterControl  -     Name$ FilterControl��$	��500��$	��200��   FilterCriteria �� *FilterCriteria+ �� Mode$ TwoWay=�2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors '  !DevExpress.Mvvm.UI.EventToCommand  �  �DevExpress.Mvvm.UI.Interactivity.EventTriggerBase`1[[System.Windows.DependencyObject, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   	EventName$ IsVisibleChanged��+	  %DevExpress.Mvvm.UI.EventToCommandBase 	  Command �� 	 �� ElementName$	 FilterControl��
 �� Path$
 ApplyFilterCommand�C
  =DevExpress.Xpf.Editors.Filtering.FilterControlColumnsBehavior
   
  UpperCasePropertyNames .  
  
ObjectType �� *
EntityType+ 
  HiddenProperties �� *HiddenProperties+ 
  AdditionalProperties �� *AdditionalProperties+ �� 	Converter 5  /DevExpress.Mvvm.UI.EnumerableConverterExtension  *5  /DevExpress.Mvvm.UI.ReflectionConverterExtension  +