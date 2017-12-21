using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model.UI;

namespace ViewManager
{
	public partial class ViewManager : Form
	{
		private bool _controlLine = true;
		private bool _controlPoint = true;
		private bool _baseWeld = true;
		private bool _baseComponent = true;
		private bool _part = true;
		private bool _boltGroup = true;
		private bool _boolean = true;

		public ViewManager()
		{
			InitializeComponent();
			InitializeUi();
		}

		private void InitializeUi()
		{
			var views = new List<Tekla.Structures.Model.UI.View>();
			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				views.Add(currentViews.Current);
			}
			listBoxViews.DataSource = views.Select(v => v.Name).ToList();
		}

		private void buttonOff_Click(object sender, System.EventArgs e)
		{
			var picker = new Picker();
			var modelObject = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_OBJECT);

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();

				var type = modelObject.GetType().Name.ToUpper();
				var baseType = modelObject.GetType().BaseType?.Name.ToUpper();

				switch (type)
				{
					case "CONTROLLINE":
						_controlLine = false;
						currentView.VisibilitySettings.ConstructionLinesVisible = false;
						currentView.VisibilitySettings.WeldsVisibleInComponents = false;
						break;
					case "CONTROLPOINT":
						_controlPoint = false;
						currentView.VisibilitySettings.PointsVisible = false;
						currentView.VisibilitySettings.PointsVisibleInComponents = false;
						currentView.VisibilitySettings.WeldsVisibleInComponents = false;
						break;
				}

				switch (baseType)
				{
					case "BASEWELD":
						_baseWeld = false;
						currentView.VisibilitySettings.WeldsVisible = false;
						currentView.VisibilitySettings.WeldsVisibleInComponents = false;
						break;
					case "BASECOMPONENT":
						_baseComponent = false;
						currentView.VisibilitySettings.ComponentsVisible = false;
						currentView.VisibilitySettings.ComponentsVisibleInComponents = false;
						break;
					case "PART":
						_part = false;
						currentView.VisibilitySettings.PartsVisible = false;
						currentView.VisibilitySettings.PartsVisibleInComponents = false;
						break;
					case "BOLTGROUP":
						_boltGroup = false;
						currentView.VisibilitySettings.BoltsVisible = false;
						currentView.VisibilitySettings.BoltsVisibleInComponents = false;
						currentView.VisibilitySettings.BoltHolesVisible = false;
						currentView.VisibilitySettings.BoltHolesVisibleInComponents = false;
						break;
					case "BOOLEAN":
						_boolean = false;
						currentView.VisibilitySettings.CutsVisible = false;
						currentView.VisibilitySettings.CutsVisibleInComponents = false;
						currentView.VisibilitySettings.FittingsVisible = false;
						currentView.VisibilitySettings.FittingsVisibleInComponents = false;
						break;
				}

				currentView.Modify();
			}
		}

		private void buttonAllOff_Click(object sender, EventArgs e)
		{
			OnOff(false);
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			OnOff(true);
		}

		private void OnOff(bool value)
		{
			_controlLine = value;
			_controlPoint = value;
			_baseWeld = value;
			_baseComponent = value;
			_part = value;
			_boltGroup = value;
			_boolean = value;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();

				currentView.VisibilitySettings.ConstructionLinesVisible = value;
				currentView.VisibilitySettings.WeldsVisibleInComponents = value;
				currentView.VisibilitySettings.PointsVisible = value;
				currentView.VisibilitySettings.PointsVisibleInComponents = value;
				currentView.VisibilitySettings.WeldsVisibleInComponents = value;
				currentView.VisibilitySettings.WeldsVisible = value;
				currentView.VisibilitySettings.WeldsVisibleInComponents = value;
				currentView.VisibilitySettings.ComponentsVisible = value;
				currentView.VisibilitySettings.ComponentsVisibleInComponents = value;
				currentView.VisibilitySettings.PartsVisible = value;
				currentView.VisibilitySettings.PartsVisibleInComponents = value;
				currentView.VisibilitySettings.BoltsVisible = value;
				currentView.VisibilitySettings.BoltsVisibleInComponents = value;
				currentView.VisibilitySettings.BoltHolesVisible = value;
				currentView.VisibilitySettings.BoltHolesVisibleInComponents = value;
				currentView.VisibilitySettings.CutsVisible = value;
				currentView.VisibilitySettings.CutsVisibleInComponents = value;
				currentView.VisibilitySettings.FittingsVisible = value;
				currentView.VisibilitySettings.FittingsVisibleInComponents = value;

				currentView.Modify();

			}
		}

		private void buttonControlLines_Click(object sender, System.EventArgs e)
		{
			_controlLine = !_controlLine;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.ConstructionLinesVisible = _controlLine;
				currentView.Modify();
			}
		}

		private void buttonControlPoint_Click(object sender, EventArgs e)
		{
			_controlPoint = !_controlPoint;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.PointsVisible = _controlPoint;
				currentView.VisibilitySettings.PointsVisibleInComponents = _controlPoint;
				currentView.Modify();
			}
		}

		private void buttonBaseWeld_Click(object sender, EventArgs e)
		{
			_baseWeld = !_baseWeld;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.WeldsVisible = _baseWeld;
				currentView.VisibilitySettings.WeldsVisibleInComponents = _baseWeld;
				currentView.Modify();
			}
		}

		private void buttonBaseComponent_Click(object sender, EventArgs e)
		{
			_baseComponent = !_baseComponent; 

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.ComponentsVisible = _baseComponent;
				currentView.VisibilitySettings.ComponentsVisibleInComponents = _baseComponent;
				currentView.Modify();
			}
		}

		private void buttonPart_Click(object sender, EventArgs e)
		{
			_part = !_part;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.PartsVisible = _part;
				currentView.VisibilitySettings.PartsVisibleInComponents = _part;
				currentView.Modify();
			}
		}

		private void buttonBoltGroup_Click(object sender, EventArgs e)
		{
			_boltGroup = !_boltGroup;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.BoltsVisible = _boltGroup;
				currentView.VisibilitySettings.BoltsVisibleInComponents = _boltGroup;
				currentView.VisibilitySettings.BoltHolesVisible = _boltGroup;
				currentView.VisibilitySettings.BoltHolesVisibleInComponents = _boltGroup;
				currentView.Modify();
			}
		}

		private void buttonCutFitting_Click(object sender, EventArgs e)
		{
			_boolean = !_boolean;

			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				currentView.Select();
				currentView.VisibilitySettings.CutsVisible = _boolean;
				currentView.VisibilitySettings.CutsVisibleInComponents = _boolean;
				currentView.VisibilitySettings.FittingsVisible = _boolean;
				currentView.VisibilitySettings.FittingsVisibleInComponents = _boolean;
				currentView.Modify();
			}
		}

		private void buttonOpenView_Click(object sender, EventArgs e)
		{
			var viewNames = listBoxViews.SelectedItems.OfType<string>().ToList();
			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				if (viewNames.Contains(currentView.Name))
				{
					ViewHandler.ShowView(currentView);
				}
			}
		}

		private void buttonCloseView_Click(object sender, EventArgs e)
		{
			var viewNames = listBoxViews.SelectedItems.OfType<string>().ToList();
			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				if (viewNames.Contains(currentView.Name))
				{
					ViewHandler.HideView(currentView);
				}
			}
		}

		private void buttonDeleteView_Click(object sender, EventArgs e)
		{
			var viewNames = listBoxViews.SelectedItems.OfType<string>().ToList();
			var currentViews = ViewHandler.GetAllViews();
			while (currentViews.MoveNext())
			{
				var currentView = currentViews.Current;
				if (viewNames.Contains(currentView.Name))
				{
					currentView.Delete();
				}
			}

			InitializeUi();
		}

		private void buttonCloseSelectedViews_Click(object sender, EventArgs e)
		{
			var views = ViewHandler.GetSelectedViews();
			while (views.MoveNext())
			{
				var view = views.Current;
				ViewHandler.HideView(view);
			}
		}

		private void buttonCloseAllViews_Click(object sender, EventArgs e)
		{
			var views = ViewHandler.GetAllViews();
			while (views.MoveNext())
			{
				var view = views.Current;
				ViewHandler.HideView(view);
			}
		}
	}
}
