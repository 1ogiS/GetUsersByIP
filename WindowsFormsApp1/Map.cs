using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
	public partial class Map : Form
	{
		public Map(Label lbl1, Label lbl2)
		{
			InitializeComponent();
			textBox2 = lbl1;
			textBox3 = lbl2;

		}

	     public Label textBox2 { get; private set; }
		 public Label textBox3 { get; private set; }

		public void MapCreate()
		{
			try
			{


				double LAT = Double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
				double LON = Double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
				gMapControl1.Bearing = 0;
				gMapControl1.CanDragMap = true; //Открываем доступ к манипулированию картой мышью через зажатие правой кнопкой(по умолчанию).
				gMapControl1.DragButton = MouseButtons.Left; //Меняем кнопку манипулирования с правой кнопки(по умолчанию) на левую кнопку мыши.
				gMapControl1.GrayScaleMode = true;
				gMapControl1.MaxZoom = 18; //Устанавливаем максимальное приближение.
				gMapControl1.MinZoom = 2; //Устанавливаем минимальное приближение.
				gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления курсор мыши.
				gMapControl1.PolygonsEnabled = true; //Открываем отображение полигонов на карте.
				gMapControl1.MarkersEnabled = true; //Открываем отображение маркеров на карте.
				gMapControl1.NegativeMode = false; //Отказываемся от негативного режима
				gMapControl1.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками
				gMapControl1.Dock = DockStyle.Fill; //Закрепляем контрол внутри формы, чтобы размеры контрола изменялись вместе с размером формы.
				gMapControl1.MapProvider = GMapProviders.BingMap; //Указываем что будут использоваться карты OpenStreetMaps. Здесь куча карт на выбор.
				GMaps.Instance.Mode = AccessMode.ServerAndCache;
				//Если у вас используется прокси то вам нужны еще эти строки, описывать не буду, скажу только что параметры входа берутся из IE:
				//GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
				//GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

				gMapControl1.Position = new GMap.NET.PointLatLng(LAT, LON); //Зададим стартовую позицию, я укажу "Красную площадь".
				GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker"); //Создадим коллекцию маркеров, указываем что имя коллекции "marker", а использоваться она будет в gMapControl1
				GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(LAT, LON)); //Создаем новый маркер.
				marker.ToolTip = new GMapRoundedToolTip(marker); //Создаем всплывающее окно
				marker.ToolTipText = "Дом"; //Задаем текст для всплывающего окна

				markersOverlay.Markers.Add(marker); //Добавляем маркер коллекцию.
				gMapControl1.Overlays.Add(markersOverlay); //Добавляем коллекцию в очередь на вывод на карту.
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public void Map_Load(object sender, EventArgs e)

		{
			MapCreate();
		}

		private void gMapControl1_Click(object sender, EventArgs e)
		{
			//contextMenuStrip1.Show();
		}

		private void гибриднаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl1.MapProvider = GMapProviders.BingHybridMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}

		private void спутникToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl1.MapProvider = GMapProviders.BingSatelliteMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}

		private void схематическаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl1.MapProvider = GMapProviders.BingMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void Map_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
			//MessageBox.Show("Не закроешь меня");
		}

	}
	}

