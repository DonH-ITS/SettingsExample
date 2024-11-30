using Microsoft.Maui.Controls.Shapes;

namespace SettingsExample
{
    public partial class MainPage : ContentPage
    {
        private Settings set;

        public MainPage() {
            InitializeComponent();
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            await Task.Delay(200);
            set = new Settings();
            Resources["GridColour1"] = Color.FromArgb(set.GRID_COLOUR1);
            Resources["GridColour2"] = Color.FromArgb(set.GRID_COLOUR2);
            CreateGrid();
        }

        private void CreateGrid() {

            int count = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Border border = new Border
                    {
                        //Stroke = Color.FromArgb("#C49B33"),
                        Stroke = new LinearGradientBrush
                        {
                            EndPoint = new Point(0, 1),
                            GradientStops = new GradientStopCollection
                            {
                                new GradientStop { Color = Colors.Orange, Offset = 0.1f },
                                new GradientStop { Color = Colors.Brown, Offset = 1.0f }
                            },
                        },
                        StrokeThickness = 2,
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill,
                        Padding = new Thickness(2, 2),
                        StrokeShape = new RoundRectangle
                        {
                            CornerRadius = new CornerRadius(5, 5, 5, 5)
                        },
                    };
                    if (count % 2 == 0)
                        border.SetDynamicResource(Border.BackgroundProperty, "GridColour1");
                    else
                        border.SetDynamicResource(Border.BackgroundProperty, "GridColour2");
                    ++count;
                    MainGrid.Add(border, j, i);

                }
            }
        }

        private async void Settings_Clicked(object sender, EventArgs e) {
           
        }


    }

}
