   M S B A M L   `   `   `  ����E  ABluePrints, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BluePrints.ViewModelsBluePrints.ViewModels  5	   	   'clr-namespace:BluePrints
BluePrints  5   	   )    #BluePrints.Views.NavigationTreeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aH 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	   f bDevExpress.Xpf.Grid.v16.1.Core, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49al hDevExpress.Xpf.Grid.v16.1.Extensions, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   	 5   	   7	viewmodel#clr-namespace:BluePrints.ViewModels   	 5	   	   ]
 YDevExpress.Mvvm.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  
 5
   	   &localclr-namespace:BluePrints  
 5   	     � 	Resources  5         groupItemStyle �� 
TargetType �� Property �� Value  filterItemStyle �� RelativeSource �� AncestorType �� Triggers P� Property P� Value��%`  &	        &	 M     �� 5   
   " Q�6'   .�5      ��  � ��$ Stretch=�6;   5      �� 5   
   " Q�6(   .�5      ��  � �� 6+   �� *
Foreground+ �� $ TreeViewL��� 5       � ��$ Stretch=�6;    5      P� 5       �@Q�
IsSelected . . �5      ��  � ��$
 Bold"�63   5      5      5      .��5      ) 	 #DevExpress.Xpf.Grid.TreeListControl  4  .DevExpress.Xpf.Core.Serialization.DXSerializer	   SerializationID$	 NavigationTree��6   $��0q�6�   
������ $��Disabled=�6  )  #DevExpress.Xpf.Grid.DataControlBase
   ItemsSource
 6K   �� *	Modules+   SelectedItem 6k   �� *SelectedModule+ �� Mode$ TwoWay=���6�   �� *Parent.Foreground+ �� *Self+   Columns 5   
   ( 	 "DevExpress.Xpf.Grid.TreeListColumn  5      $  DevExpress.Xpf.Grid.BaseColumn   Header)  #DevExpress.Xpf.Core.ObjectConverter$ Title 6!   $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ ModuleTitle��60      VisibleIndex$ 0��6H      Width2  ,DevExpress.Xpf.Grid.GridColumnWidthConverter$ * 6Y      View 5    
   &	 	  DevExpress.Xpf.Grid.TreeListView	  5!      -   5         	 Name$ TreeListView��5!       	  ShowNodeImages .  	  TreeLineStyle$
 None=�6K    	  ExpandStateFieldName$ 
IsExpanded��6`    	  ImageFieldName$ TreeViewImage��6�   &
   DevExpress.Xpf.Grid.DataViewBase 
  AllowEditing .   
  AllowSorting .   	  ParentFieldName$ TreeViewParentId��6�    	  KeyFieldName$ 
TreeViewId��6�   2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors 5"      '  !DevExpress.Mvvm.UI.EventToCommand  5#      �  �DevExpress.Mvvm.UI.Interactivity.EventTriggerBase`1[[System.Windows.DependencyObject, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   	EventName$ MouseDoubleClick��6,   +  %DevExpress.Mvvm.UI.EventToCommandBase   Command 6I   �� *NavigateCommand+5%      5'      5(      