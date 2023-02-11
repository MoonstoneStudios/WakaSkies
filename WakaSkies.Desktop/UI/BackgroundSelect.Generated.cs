/* Generated by MyraPad at 2/11/2023 8:32:18 AM */
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
	partial class BackgroundSelect: Grid
	{
		private void BuildUI()
		{
			var label1 = new Label();
			label1.Text = "Background";
			label1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;

			closeBackground = new TextButton();
			closeBackground.Text = "Close";
			closeBackground.Padding = new Thickness(3);
			closeBackground.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Right;
			closeBackground.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			closeBackground.GridColumn = 1;
			closeBackground.Id = "closeBackground";

			background0 = new ImageButton();
			background0.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail0.png");
			background0.ImageWidth = 45;
			background0.ImageHeight = 45;
			background0.Padding = new Thickness(3);
			background0.Id = "background0";

			background1 = new ImageButton();
			background1.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail1.png");
			background1.ImageWidth = 45;
			background1.ImageHeight = 45;
			background1.Padding = new Thickness(3);
			background1.Id = "background1";

			background2 = new ImageButton();
			background2.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail2.png");
			background2.ImageWidth = 45;
			background2.ImageHeight = 45;
			background2.Padding = new Thickness(3);
			background2.Id = "background2";

			background3 = new ImageButton();
			background3.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail3.png");
			background3.ImageWidth = 45;
			background3.ImageHeight = 45;
			background3.Padding = new Thickness(3);
			background3.Id = "background3";

			background4 = new ImageButton();
			background4.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail4.png");
			background4.ImageWidth = 45;
			background4.ImageHeight = 45;
			background4.Padding = new Thickness(3);
			background4.Id = "background4";

			background5 = new ImageButton();
			background5.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail5.png");
			background5.ImageWidth = 45;
			background5.ImageHeight = 45;
			background5.Padding = new Thickness(3);
			background5.Id = "background5";

			background6 = new ImageButton();
			background6.Image = MyraEnvironment.DefaultAssetManager.Load<TextureRegion>("Skyboxes/thumbnail6.png");
			background6.ImageWidth = 45;
			background6.ImageHeight = 45;
			background6.Padding = new Thickness(3);
			background6.Id = "background6";

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 5;
			horizontalStackPanel1.Margin = new Thickness(0, 10, 0, 0);
			horizontalStackPanel1.GridRow = 1;
			horizontalStackPanel1.GridColumnSpan = 2;
			horizontalStackPanel1.Widgets.Add(background0);
			horizontalStackPanel1.Widgets.Add(background1);
			horizontalStackPanel1.Widgets.Add(background2);
			horizontalStackPanel1.Widgets.Add(background3);
			horizontalStackPanel1.Widgets.Add(background4);
			horizontalStackPanel1.Widgets.Add(background5);
			horizontalStackPanel1.Widgets.Add(background6);

			
			ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Bottom;
			Width = 400;
			Height = 100;
			Padding = new Thickness(5);
			Background = new SolidBrush("#252526FF");
			Id = "backgroundSelectGrid";
			Widgets.Add(label1);
			Widgets.Add(closeBackground);
			Widgets.Add(horizontalStackPanel1);
		}

		
		public TextButton closeBackground;
		public ImageButton background0;
		public ImageButton background1;
		public ImageButton background2;
		public ImageButton background3;
		public ImageButton background4;
		public ImageButton background5;
		public ImageButton background6;
	}
}
