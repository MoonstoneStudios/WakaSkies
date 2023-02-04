/* Generated by MyraPad at 2/4/2023 10:14:45 AM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WakaSkies.Desktop.UI
{
	partial class MoreSettings: Dialog
	{
		private void BuildUI()
		{
			generateStats = new CheckBox();
			generateStats.IsChecked = true;
			generateStats.Text = "Add Stats To Model  ";
			generateStats.TextPosition = Myra.Graphics2D.UI.ImageTextButton.TextPositionEnum.Left;
			generateStats.Id = "generateStats";

			roundHour = new CheckBox();
			roundHour.Text = "Round To Nearest Hour  ";
			roundHour.TextPosition = Myra.Graphics2D.UI.ImageTextButton.TextPositionEnum.Left;
			roundHour.Id = "roundHour";

			var label1 = new Label();
			label1.Text = "Minimum Hours";
			label1.Margin = new Thickness(0, 0, 10, 0);

			minHours = new SpinButton();
			minHours.Maximum = 12;
			minHours.Minimum = 0;
			minHours.Integer = true;
			minHours.MinWidth = 100;
			minHours.Id = "minHours";

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Widgets.Add(label1);
			horizontalStackPanel1.Widgets.Add(minHours);

			var label2 = new Label();
			label2.Text = "Minimum Height Of Bars (More Than 0 Hours)";
			label2.Margin = new Thickness(0, 0, 10, 0);

			minHeight = new SpinButton();
			minHeight.Maximum = 3;
			minHeight.Minimum = 0;
			minHeight.Integer = true;
			minHeight.MinWidth = 100;
			minHeight.Id = "minHeight";

			var horizontalStackPanel2 = new HorizontalStackPanel();
			horizontalStackPanel2.Widgets.Add(label2);
			horizontalStackPanel2.Widgets.Add(minHeight);

			var label3 = new Label();
			label3.Text = "Maximum Height Of Bars";
			label3.Margin = new Thickness(0, 0, 10, 0);

			maxHeight = new SpinButton();
			maxHeight.Maximum = 12;
			maxHeight.Minimum = 4;
			maxHeight.Value = 8;
			maxHeight.Integer = true;
			maxHeight.MinWidth = 100;
			maxHeight.Id = "maxHeight";

			var horizontalStackPanel3 = new HorizontalStackPanel();
			horizontalStackPanel3.Widgets.Add(label3);
			horizontalStackPanel3.Widgets.Add(maxHeight);

			addBorder = new CheckBox();
			addBorder.IsChecked = true;
			addBorder.Text = "Add Border To Base  ";
			addBorder.TextPosition = Myra.Graphics2D.UI.ImageTextButton.TextPositionEnum.Left;
			addBorder.Id = "addBorder";

			useDefaultTimeout = new CheckBox();
			useDefaultTimeout.IsChecked = true;
			useDefaultTimeout.Text = "Use Account\'s Default Keystroke Timeout  ";
			useDefaultTimeout.TextPosition = Myra.Graphics2D.UI.ImageTextButton.TextPositionEnum.Left;
			useDefaultTimeout.Id = "useDefaultTimeout";

			var label4 = new Label();
			label4.Text = "Keystroke Timeout";
			label4.Margin = new Thickness(0, 0, 10, 0);

			timeout = new SpinButton();
			timeout.Maximum = 250;
			timeout.Minimum = 5;
			timeout.Value = 15;
			timeout.Integer = true;
			timeout.MinWidth = 100;
			timeout.Id = "timeout";

			timeoutOptions = new HorizontalStackPanel();
			timeoutOptions.Margin = new Thickness(25, 0, 0, 0);
			timeoutOptions.Visible = false;
			timeoutOptions.Id = "timeoutOptions";
			timeoutOptions.Widgets.Add(label4);
			timeoutOptions.Widgets.Add(timeout);

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Spacing = 5;
			verticalStackPanel1.Margin = new Thickness(10, 0);
			verticalStackPanel1.Widgets.Add(generateStats);
			verticalStackPanel1.Widgets.Add(roundHour);
			verticalStackPanel1.Widgets.Add(horizontalStackPanel1);
			verticalStackPanel1.Widgets.Add(horizontalStackPanel2);
			verticalStackPanel1.Widgets.Add(horizontalStackPanel3);
			verticalStackPanel1.Widgets.Add(addBorder);
			verticalStackPanel1.Widgets.Add(useDefaultTimeout);
			verticalStackPanel1.Widgets.Add(timeoutOptions);

			
			Title = "More Settings";
			Left = 478;
			Top = 151;
			MinWidth = 500;
			MinHeight = 300;
			Id = "moreSettingsDialog";
			Content = verticalStackPanel1;
		}

		
		public CheckBox generateStats;
		public CheckBox roundHour;
		public SpinButton minHours;
		public SpinButton minHeight;
		public SpinButton maxHeight;
		public CheckBox addBorder;
		public CheckBox useDefaultTimeout;
		public SpinButton timeout;
		public HorizontalStackPanel timeoutOptions;
	}
}
