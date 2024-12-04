
namespace SettingsExample
{
    public class Settings
    {
        private string grid_colour1;
        private string grid_colour2;

        public string GRID_COLOUR1
        {
            get => grid_colour1;
            set
            {
                if (grid_colour1 != value) {
                    grid_colour1 = value;
                }
            }
        }
        public string GRID_COLOUR2
        {
            get => grid_colour2;
            set
            {
                if (grid_colour2 != value) {
                    grid_colour2 = value;
                }
            }
        }

        public Settings() {
            //Have Default Settings in the Constructor
            GRID_COLOUR1 = "#2B0B98";
            GRID_COLOUR2 = "#FB0B98";
        }

        public void SaveJson() {
            string jsonstring = JsonSerializer.Serialize(this);
            string filename = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "settings.json");
            using (StreamWriter writer = new StreamWriter(filename)) {
                writer.Write(jsonstring);
            }
        }
}
    }
}
